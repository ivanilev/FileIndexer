namespace FileIndexer
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
            this.panelTopContainer = new System.Windows.Forms.Panel();
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SplitContainer = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelBotContainer = new System.Windows.Forms.Panel();
            this.tbSelectedNode = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panelTopContainer.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).BeginInit();
            this.SplitContainer.Panel1.SuspendLayout();
            this.SplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelBotContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTopContainer
            // 
            this.panelTopContainer.Controls.Add(this.btnSelectFolder);
            this.panelTopContainer.Controls.Add(this.label1);
            this.panelTopContainer.Location = new System.Drawing.Point(12, 33);
            this.panelTopContainer.Name = "panelTopContainer";
            this.panelTopContainer.Size = new System.Drawing.Size(984, 52);
            this.panelTopContainer.TabIndex = 0;
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Location = new System.Drawing.Point(276, 7);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(201, 37);
            this.btnSelectFolder.TabIndex = 3;
            this.btnSelectFolder.Text = "Browse...";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(34, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 37);
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
            this.SplitContainer.Size = new System.Drawing.Size(984, 515);
            this.SplitContainer.SplitterDistance = 477;
            this.SplitContainer.TabIndex = 0;
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
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(477, 515);
            this.treeView1.TabIndex = 1;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.panelBotContainer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelTopContainer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelTopContainer.ResumeLayout(false);
            this.panelTopContainer.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.SplitContainer.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).EndInit();
            this.SplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelBotContainer.ResumeLayout(false);
            this.panelBotContainer.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.TreeView treeView1;
    }
}

