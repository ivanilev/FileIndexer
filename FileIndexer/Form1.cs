using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace FileIndexer
{
    public partial class Form1 : Form
    {
        public Controller.IndexerController indexController = new Controller.IndexerController();

        public Form1()
        {
            InitializeComponent();
        }

        #region Event handlers

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();

            if(result == DialogResult.Cancel) { return; }

            string selectedPath = folderBrowserDialog1.SelectedPath;

            if(treeView1.Nodes.Count>0)
                treeView1.Nodes.Clear();

            try
            {
                treeView1.Nodes.Add(PopulateTree(indexController.GetAllFilesRecursively(selectedPath)));
            }

            catch(UnauthorizedAccessException ex)
            {
                MessageBox.Show(ex.Message);
                btnSelectFolder.Focus();
            }


            btnSearch.Enabled = true;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            FileSystemInfo fsi;
            string selectedNodeFullFilePath = string.Empty;

            //If the selected note (file or folder) is found in the controller's dictionary - assign its value to "selectedNodeFullFilePath"
            if (indexController.MyDict.Any(kvp => kvp.Key.Contains(treeView1.SelectedNode.Text)))
            {
                selectedNodeFullFilePath = indexController.MyDict.Keys.SingleOrDefault(x => x.EndsWith(treeView1.SelectedNode.Text));
            }
            else
            {
                tbSelectedNode.BackColor = Color.Red;
                tbSelectedNode.Text = "Error, file not found!";
            }

            bool itworks = indexController.MyDict.TryGetValue(selectedNodeFullFilePath, out fsi);

            if (itworks)
            {
                indexController.SelectedFile = fsi;
                tbSelectedNode.Text = fsi.FullName;
                tbSelectedNode.BackColor = SystemColors.Control;
               
            }
            else
            {
                indexController.SelectedFile = null;
                tbSelectedNode.BackColor = System.Drawing.Color.Red;
                tbSelectedNode.Text = "Error!";
            }
           
            tbFileInfo.Text = indexController.GetFileInfo(indexController.SelectedFile);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchString = tbSearch.Text;

            if (string.IsNullOrEmpty(tbSearch.Text)) { tbSearch.Focus(); return; }

            string fullFilePath = indexController.MyDict.Keys.FirstOrDefault(x => x.Contains(searchString));
            FileSystemInfo foundItem;

            bool itworks = indexController.MyDict.TryGetValue(fullFilePath, out foundItem);

            if (!itworks) { tbSearch.Text = "Error!"; tbSearch.Focus(); return; }

            indexController.SelectedFile = foundItem;
            tbSelectedNode.Text = foundItem.FullName;
            tbFileInfo.Text = indexController.GetFileInfo(indexController.SelectedFile);
            treeView1.ExpandAll();
        }
        #endregion Event handlers

        #region Functions

        /// <summary>
        /// Checks if a node has GrandChildren.
        /// </summary>
        /// <param name="tree"></param>
        /// <returns></returns>
        private bool HasGrandChildren(TreeNode<FileSystemInfo> tree)
        {
            var children = tree.GetCurrentNodeChildren();
            foreach (TreeNode<FileSystemInfo> child in children)
            {
                if (child.GetCurrentNodeChildren() != null && child.GetCurrentNodeChildren().Count > 0)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Recursively iterates through the entire tree and returns a TreeNode of all files and folders within a folder.
        /// </summary>
        /// <param name="tree">A folder to iterate through</param>
        /// <returns>A tree node of all files and folders within the folder in the parameter.</returns>
        private TreeNode PopulateTree(TreeNode<FileSystemInfo> tree)
        {

            List<TreeNode> list = new List<TreeNode>();


            if (HasGrandChildren(tree) == false)
            {
                var children = tree.GetCurrentNodeChildren();

                foreach (TreeNode<FileSystemInfo> child in children)
                {
                    list.Add(new TreeNode(child.GetCurrentNodeData().Name));
                }
                return new TreeNode(tree.GetCurrentNodeData().Name, list.ToArray());
            }
            else
            {
                var children = tree.GetCurrentNodeChildren();

                foreach (TreeNode<FileSystemInfo> child in children)
                {
                    if (child.GetType() == typeof(FileInfo))
                    {
                        list.Add(new TreeNode(child.GetCurrentNodeData().Name));
                    }
                    else
                    {
                        list.Add(PopulateTree(child));
                    }
                }
                return new TreeNode(tree.GetCurrentNodeData().Name, list.ToArray());
            }
        }

        #endregion

     
    }
}
