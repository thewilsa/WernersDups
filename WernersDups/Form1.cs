using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using WernersDups.Classes;
using System.Runtime.CompilerServices;
using System.IO;

namespace WernersDups
{
    public partial class Form1 : Form
    {
        Duplicate dup = new Duplicate();

        BindingList<DuplicateEntry> dups = new BindingList<DuplicateEntry>();
        Boolean isSearching = false;

        // Storage for all JPGS and possible dups
        private static long filesfound = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // For Now
#if DEBUG
            Application.Exit();
#endif
            DialogResult result1 = MessageBox.Show("Are you sure?", "Leave the program", MessageBoxButtons.YesNo);
            if(result1 == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_BeginSearch_Click(object sender, EventArgs e)
        {
            // Traverse the tree to accumulate files
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                onBeginSearching();
                isSearching = true;
                TraverseTree(fbd.SelectedPath);
                isSearching = false;
                updateDuplicateListBoxWithResults();
            }


                

        }

        private void updateDuplicateListBoxWithResults()
        {
            lbDuplicates.DataSource = dup.getDups();
            lbDuplicates.DisplayMember = "path";
            lbDuplicates.ValueMember = "dup_of";
            lbDuplicates.Refresh();
            lbDuplicates.Update();

        }

        private void onBeginSearching()
        {
            dup.Init();

            clearImage(pbCatalog);
            clearImage(pbDuplicate);
            filesfound = 0;
            lblFilesFound.Text = string.Empty;
            lblImagesFound.Text = string.Empty;
            lblDuplicatesFound.Text = string.Empty;
            lblPossibleDuplicateOf.Text = string.Empty;
        }

        private void clearImage(PictureBox pb)
        {
            if(pb.Image != null)
            {
                pb.Image.Dispose();
                pb.Image = null;
            }
        }

        private void SetImages()
        {
            try 
            {
                if(!isSearching && lbDuplicates.SelectedIndex > -1 && lbDuplicates.Items.Count > 0)
                {
                    DuplicateEntry de = lbDuplicates.SelectedItem as DuplicateEntry;
                    pbDuplicate.Image = Image.FromFile(lbDuplicates.GetItemText(de.path));

                    string dup_of_path = dup.getImageFromId(de.dup_of);
                    if(dup_of_path.Length > 0)
                    {
                        pbCatalog.Image = Image.FromFile(dup_of_path);
                        lblPossibleDuplicateOf.Text = dup_of_path;
                        pbCatalog.Visible = true;
                    }
                    else
                    {
                        pbCatalog.Visible = false;
                    }
                }

            }
            catch (System.IO.InvalidDataException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (System.IO.FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }


        }

        private void TraverseTree(string root)
        {
            // Data structure to hold names of subfolders to be
            // examined for files.
            Stack<string> dirs = new Stack<string>(20);

            if (!System.IO.Directory.Exists(root))
            {
                throw new ArgumentException();
            }
            dirs.Push(root);

            while (dirs.Count > 0)
            {
                string currentDir = dirs.Pop();
                string[] subDirs;
                try
                {
                    subDirs = System.IO.Directory.GetDirectories(currentDir);
                }
                // An UnauthorizedAccessException exception will be thrown if we do not have
                // discovery permission on a folder or file. It may or may not be acceptable
                // to ignore the exception and continue enumerating the remaining files and
                // folders. It is also possible (but unlikely) that a DirectoryNotFound exception
                // will be raised. This will happen if currentDir has been deleted by
                // another application or thread after our call to Directory.Exists. The
                // choice of which exceptions to catch depends entirely on the specific task
                // you are intending to perform and also on how much you know with certainty
                // about the systems on which this code will run.
                catch (UnauthorizedAccessException e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }
                catch (System.IO.DirectoryNotFoundException e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }

                string[] files = null;
                try
                {
                    files = System.IO.Directory.GetFiles(currentDir);
                }

                catch (UnauthorizedAccessException e)
                {

                    Console.WriteLine(e.Message);
                    continue;
                }

                catch (System.IO.DirectoryNotFoundException e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }
                // Perform the required action on each file here.
                // Modify this block to perform your required task.
                foreach (string file in files)
                {
                    filesfound++;
                    lblFilesFound.Text = "Files Found: " + filesfound.ToString();
                    if(System.Web.MimeMapping.GetMimeMapping(file).StartsWith("image"))
                    {
                        try
                        {
                            // Perform whatever action is required in your scenario.
                            System.IO.FileInfo fi = new System.IO.FileInfo(file);
                            dup.push(fi.FullName, fi.Length, fi .CreationTime);
                            lblDuplicatesFound.Text = "Duplicates Found: " + dup.getDupCount().ToString();
                            lblImagesFound.Text = "Images Found: " + dup.getImageCount().ToString();

                        }
                        catch (System.IO.FileNotFoundException e)
                        {
                            // If file was deleted by a separate application
                            //  or thread since the call to TraverseTree()
                            // then just continue.
                            Console.WriteLine(e.Message);
                            continue;
                        }
                    }
                }

                // Push the subdirectories onto the stack for traversal.
                // This could also be done before handing the files.
                foreach (string str in subDirs)
                    dirs.Push(str);
            }

            lblImagesFound.Text = "Images Found: " + dup.getImageCount().ToString();

        }

        private void lbDuplicates_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetImages();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            onBeginSearching();
            updateDuplicateListBoxWithResults();
        }
    }
}
