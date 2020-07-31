using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WernersDups.Classes
{

    class DirectoryEntry
    {
        public string id { get; set; }
        public string path { get; set; }
        public long size { get; set; }
        public DateTime createdate { get; set; }

        List<DirectoryEntry> catalog = new List<DirectoryEntry>();
        List<DuplicateEntry> dups = new List<DuplicateEntry>();


        public DirectoryEntry(string path, long size, DateTime createdate)
        {
            this.id = Guid.NewGuid().ToString();
            this.path = path;
            this.size = size;
            this.createdate = createdate;
        }
    }

    class DuplicateEntry
    {
        public string path { get; set; }
        public string dup_of { get; set; }

        public DuplicateEntry(string path, string dup_of)
        {
            this.path = path;
            this.dup_of = dup_of;
        }
    }

    class Duplicate
    {
        private List<DirectoryEntry> catalog;
        private List<DuplicateEntry> dups;

        public BindingList<DuplicateEntry> getDups()
        {
            BindingList<DuplicateEntry> bdups = new BindingList<DuplicateEntry>();
            foreach(DuplicateEntry entry in dups)
            {
                bdups.Add(entry);
            }
            return bdups;
        }
        public int getImageCount()
        {
            return catalog.Count;
        }

        public int getDupCount()
        {
            return dups.Count;
        }
        public Duplicate()
        {
            catalog = new List<DirectoryEntry>();
            dups = new List<DuplicateEntry>();
        }

        public void Init()
        {
            this.catalog.Clear();
            this.dups.Clear();
        }

        public string getImageFromId(string id)
        {
            foreach (DirectoryEntry entry in catalog)
            {
                if (entry.id.ToString() == id)
                {
                    return entry.path;
                }
            }

            return "";

        }

        public void push(string path, long size, DateTime createdate)
        {
            // If it doesn't exist in the catalog, add it.
            // catalog is empty?
            if (catalog.Count == 0)
            {
                addToCatalog(path, size, createdate);
            }
            else
            {
                // search catalog by filename (without the Path) and file size
                foreach (DirectoryEntry entry in catalog)
                {

                    if (Path.GetFileName(path) == Path.GetFileName(entry.path) && size == entry.size)
                    {
                        // A File with this name and size already exists, add to duplicates
                        dups.Add(new DuplicateEntry(path, entry.id));
                        return;
                    }
                }
                // Didn't find anything...add to catalog
                addToCatalog(path, size, createdate);
            }
        }

        private void addToCatalog(string path, long size, DateTime createdate)
        {
            catalog.Add(new DirectoryEntry(path, size, createdate));
        }

        private string getFilenameFromPath(string path)
        {
            return Path.GetFileName(path);
        }

    }


}
