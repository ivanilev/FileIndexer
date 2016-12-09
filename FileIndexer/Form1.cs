using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace FileIndexer
{
    public partial class Form1 : Form
    {
        public Controller.IndexerController ic = new Controller.IndexerController();

        public Form1()
        {
            InitializeComponent();
        }

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

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            string selectedPath = folderBrowserDialog1.SelectedPath;

            treeView1.Nodes.Add(PopulateTree(ic.GetAllFilesRecursively(selectedPath)));

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

            string result = string.Empty;
            if (ic.MyDict.Any(kvp => kvp.Key.Contains(treeView1.SelectedNode.Text)))
            {
                result = ic.MyDict.Keys.SingleOrDefault(x => x.EndsWith(treeView1.SelectedNode.Text));
            }

            if (string.IsNullOrEmpty(result))
            {
                result = "Error!";
            }

            tbSelectedNode.Text = result;
        }
    }
}
