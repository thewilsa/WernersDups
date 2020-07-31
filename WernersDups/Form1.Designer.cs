namespace WernersDups
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.btn_BeginSearch = new System.Windows.Forms.Button();
            this.lblFilesFound = new System.Windows.Forms.Label();
            this.lblImagesFound = new System.Windows.Forms.Label();
            this.lblDuplicatesFound = new System.Windows.Forms.Label();
            this.lbDuplicates = new System.Windows.Forms.ListBox();
            this.pbCatalog = new System.Windows.Forms.PictureBox();
            this.pbDuplicate = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPossibleDuplicateOf = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnClearSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbCatalog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDuplicate)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(583, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_BeginSearch
            // 
            this.btn_BeginSearch.Location = new System.Drawing.Point(37, 29);
            this.btn_BeginSearch.Name = "btn_BeginSearch";
            this.btn_BeginSearch.Size = new System.Drawing.Size(116, 23);
            this.btn_BeginSearch.TabIndex = 1;
            this.btn_BeginSearch.Text = "Begin New Search";
            this.btn_BeginSearch.UseVisualStyleBackColor = true;
            this.btn_BeginSearch.Click += new System.EventHandler(this.btn_BeginSearch_Click);
            // 
            // lblFilesFound
            // 
            this.lblFilesFound.AutoSize = true;
            this.lblFilesFound.Location = new System.Drawing.Point(6, 26);
            this.lblFilesFound.Name = "lblFilesFound";
            this.lblFilesFound.Size = new System.Drawing.Size(67, 13);
            this.lblFilesFound.TabIndex = 2;
            this.lblFilesFound.Text = "Files Found: ";
            // 
            // lblImagesFound
            // 
            this.lblImagesFound.AutoSize = true;
            this.lblImagesFound.Location = new System.Drawing.Point(6, 50);
            this.lblImagesFound.Name = "lblImagesFound";
            this.lblImagesFound.Size = new System.Drawing.Size(77, 13);
            this.lblImagesFound.TabIndex = 3;
            this.lblImagesFound.Text = "Images Found:";
            // 
            // lblDuplicatesFound
            // 
            this.lblDuplicatesFound.AutoSize = true;
            this.lblDuplicatesFound.Location = new System.Drawing.Point(6, 73);
            this.lblDuplicatesFound.Name = "lblDuplicatesFound";
            this.lblDuplicatesFound.Size = new System.Drawing.Size(93, 13);
            this.lblDuplicatesFound.TabIndex = 5;
            this.lblDuplicatesFound.Text = "Duplicates Found:";
            // 
            // lbDuplicates
            // 
            this.lbDuplicates.FormattingEnabled = true;
            this.lbDuplicates.Location = new System.Drawing.Point(37, 98);
            this.lbDuplicates.Name = "lbDuplicates";
            this.lbDuplicates.Size = new System.Drawing.Size(395, 173);
            this.lbDuplicates.TabIndex = 7;
            this.lbDuplicates.SelectedIndexChanged += new System.EventHandler(this.lbDuplicates_SelectedIndexChanged);
            // 
            // pbCatalog
            // 
            this.pbCatalog.Location = new System.Drawing.Point(37, 301);
            this.pbCatalog.Name = "pbCatalog";
            this.pbCatalog.Size = new System.Drawing.Size(259, 180);
            this.pbCatalog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCatalog.TabIndex = 8;
            this.pbCatalog.TabStop = false;
            // 
            // pbDuplicate
            // 
            this.pbDuplicate.Location = new System.Drawing.Point(442, 97);
            this.pbDuplicate.Name = "pbDuplicate";
            this.pbDuplicate.Size = new System.Drawing.Size(216, 174);
            this.pbDuplicate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDuplicate.TabIndex = 9;
            this.pbDuplicate.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Possible Duplicate of: ";
            // 
            // lblPossibleDuplicateOf
            // 
            this.lblPossibleDuplicateOf.AutoSize = true;
            this.lblPossibleDuplicateOf.Location = new System.Drawing.Point(144, 285);
            this.lblPossibleDuplicateOf.Name = "lblPossibleDuplicateOf";
            this.lblPossibleDuplicateOf.Size = new System.Drawing.Size(54, 13);
            this.lblPossibleDuplicateOf.TabIndex = 11;
            this.lblPossibleDuplicateOf.Text = "File Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Image Duplicates";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblDuplicatesFound);
            this.groupBox2.Controls.Add(this.lblImagesFound);
            this.groupBox2.Controls.Add(this.lblFilesFound);
            this.groupBox2.Location = new System.Drawing.Point(442, 301);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(216, 111);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search Results";
            // 
            // btnClearSearch
            // 
            this.btnClearSearch.Location = new System.Drawing.Point(182, 29);
            this.btnClearSearch.Name = "btnClearSearch";
            this.btnClearSearch.Size = new System.Drawing.Size(102, 23);
            this.btnClearSearch.TabIndex = 18;
            this.btnClearSearch.Text = "Clear Search";
            this.btnClearSearch.UseVisualStyleBackColor = true;
            this.btnClearSearch.Click += new System.EventHandler(this.btnClearSearch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 494);
            this.Controls.Add(this.btnClearSearch);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPossibleDuplicateOf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbDuplicate);
            this.Controls.Add(this.pbCatalog);
            this.Controls.Add(this.lbDuplicates);
            this.Controls.Add(this.btn_BeginSearch);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Werner\'s Duplicate Images";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCatalog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDuplicate)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_BeginSearch;
        private System.Windows.Forms.Label lblFilesFound;
        private System.Windows.Forms.Label lblImagesFound;
        private System.Windows.Forms.Label lblDuplicatesFound;
        private System.Windows.Forms.ListBox lbDuplicates;
        private System.Windows.Forms.PictureBox pbCatalog;
        private System.Windows.Forms.PictureBox pbDuplicate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPossibleDuplicateOf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnClearSearch;
    }
}

