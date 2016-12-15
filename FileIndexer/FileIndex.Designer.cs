namespace FileIndexer
{
    partial class FileIndex
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
            this.components = new System.ComponentModel.Container();
            this.panelTopContainer = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SplitContainer = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pbFileImage = new System.Windows.Forms.PictureBox();
            this.tbFileInfo = new System.Windows.Forms.TextBox();
            this.panelBotContainer = new System.Windows.Forms.Panel();
            this.tbSelectedNode = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cmsNodeClick = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmOpenImage = new System.Windows.Forms.ToolStripMenuItem();
            this.indexerControllerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelTopContainer.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).BeginInit();
            this.SplitContainer.Panel1.SuspendLayout();
            this.SplitContainer.Panel2.SuspendLayout();
            this.SplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFileImage)).BeginInit();
            this.panelBotContainer.SuspendLayout();
            this.cmsNodeClick.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.indexerControllerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTopContainer
            // 
            this.panelTopContainer.Controls.Add(this.btnSearch);
            this.panelTopContainer.Controls.Add(this.btnSelectFolder);
            this.panelTopContainer.Controls.Add(this.tbSearch);
            this.panelTopContainer.Controls.Add(this.lblSearch);
            this.panelTopContainer.Controls.Add(this.label1);
            this.panelTopContainer.Location = new System.Drawing.Point(12, 12);
            this.panelTopContainer.Name = "panelTopContainer";
            this.panelTopContainer.Size = new System.Drawing.Size(984, 73);
            this.panelTopContainer.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Enabled = false;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSearch.Location = new System.Drawing.Point(821, 21);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(140, 37);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSelectFolder.Location = new System.Drawing.Point(264, 19);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(201, 37);
            this.btnSelectFolder.TabIndex = 3;
            this.btnSelectFolder.Text = "Browse...";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Enabled = false;
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSearch.Location = new System.Drawing.Point(628, 25);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(187, 29);
            this.tbSearch.TabIndex = 3;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSearch.Location = new System.Drawing.Point(471, 12);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(151, 44);
            this.lblSearch.TabIndex = 4;
            this.lblSearch.Text = "Search:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Folder:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.SplitContainer);
            this.panel2.Location = new System.Drawing.Point(12, 91);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(984, 515);
            this.panel2.TabIndex = 1;
            // 
            // SplitContainer
            // 
            this.SplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainer.Location = new System.Drawing.Point(0, 0);
            this.SplitContainer.Name = "SplitContainer";
            // 
            // SplitContainer.Panel1
            // 
            this.SplitContainer.Panel1.AccessibleName = "splitContinerLeftPanel";
            this.SplitContainer.Panel1.Controls.Add(this.treeView1);
            this.SplitContainer.Panel1.Controls.Add(this.dataGridView1);
            // 
            // SplitContainer.Panel2
            // 
            this.SplitContainer.Panel2.AccessibleName = "SplitContainerRightPanel";
            this.SplitContainer.Panel2.Controls.Add(this.pbFileImage);
            this.SplitContainer.Panel2.Controls.Add(this.tbFileInfo);
            this.SplitContainer.Size = new System.Drawing.Size(984, 515);
            this.SplitContainer.SplitterDistance = 477;
            this.SplitContainer.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(477, 515);
            this.treeView1.TabIndex = 1;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            this.treeView1.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseDoubleClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(477, 515);
            this.dataGridView1.TabIndex = 0;
            // 
            // pbFileImage
            // 
            this.pbFileImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbFileImage.Enabled = false;
            this.pbFileImage.Location = new System.Drawing.Point(0, 0);
            this.pbFileImage.Name = "pbFileImage";
            this.pbFileImage.Size = new System.Drawing.Size(503, 515);
            this.pbFileImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFileImage.TabIndex = 1;
            this.pbFileImage.TabStop = false;
            this.pbFileImage.Visible = false;
            this.pbFileImage.DoubleClick += new System.EventHandler(this.pbFileImage_DoubleClick);
            // 
            // tbFileInfo
            // 
            this.tbFileInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbFileInfo.Location = new System.Drawing.Point(0, 0);
            this.tbFileInfo.Multiline = true;
            this.tbFileInfo.Name = "tbFileInfo";
            this.tbFileInfo.ReadOnly = true;
            this.tbFileInfo.Size = new System.Drawing.Size(503, 515);
            this.tbFileInfo.TabIndex = 0;
            this.tbFileInfo.DoubleClick += new System.EventHandler(this.tbFileInfo_DoubleClick);
            // 
            // panelBotContainer
            // 
            this.panelBotContainer.Controls.Add(this.tbSelectedNode);
            this.panelBotContainer.Location = new System.Drawing.Point(12, 612);
            this.panelBotContainer.Name = "panelBotContainer";
            this.panelBotContainer.Size = new System.Drawing.Size(984, 105);
            this.panelBotContainer.TabIndex = 1;
            // 
            // tbSelectedNode
            // 
            this.tbSelectedNode.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSelectedNode.Location = new System.Drawing.Point(0, 35);
            this.tbSelectedNode.Name = "tbSelectedNode";
            this.tbSelectedNode.ReadOnly = true;
            this.tbSelectedNode.Size = new System.Drawing.Size(984, 35);
            this.tbSelectedNode.TabIndex = 4;
            this.tbSelectedNode.WordWrap = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cmsNodeClick
            // 
            this.cmsNodeClick.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmOpenImage});
            this.cmsNodeClick.Name = "cmsNodeClick";
            this.cmsNodeClick.Size = new System.Drawing.Size(104, 26);
            // 
            // tsmOpenImage
            // 
            this.tsmOpenImage.Name = "tsmOpenImage";
            this.tsmOpenImage.Size = new System.Drawing.Size(103, 22);
            this.tsmOpenImage.Text = "Open";
            this.tsmOpenImage.Click += new System.EventHandler(this.tsmOpenFile_Click);
            // 
            // indexerControllerBindingSource
            // 
            this.indexerControllerBindingSource.DataSource = typeof(FileIndexer.Controller.IndexerController);
            // 
            // FileIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.panelBotContainer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelTopContainer);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FileIndex";
            this.Text = "File Indexer";
            this.panelTopContainer.ResumeLayout(false);
            this.panelTopContainer.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.SplitContainer.Panel1.ResumeLayout(false);
            this.SplitContainer.Panel2.ResumeLayout(false);
            this.SplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).EndInit();
            this.SplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFileImage)).EndInit();
            this.panelBotContainer.ResumeLayout(false);
            this.panelBotContainer.PerformLayout();
            this.cmsNodeClick.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.indexerControllerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTopContainer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.SplitContainer SplitContainer;
        private System.Windows.Forms.Panel panelBotContainer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.TextBox tbSelectedNode;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.BindingSource indexerControllerBindingSource;
        private System.Windows.Forms.TextBox tbFileInfo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.PictureBox pbFileImage;
        private System.Windows.Forms.ContextMenuStrip cmsNodeClick;
        private System.Windows.Forms.ToolStripMenuItem tsmOpenImage;
    }
}

