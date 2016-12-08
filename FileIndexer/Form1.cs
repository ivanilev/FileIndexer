using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace FileIndexer
{
    public partial class Form1 : Form
    {
        public FileIndexer.Controller.IndexerController ic = new Controller.IndexerController();

        public Form1()
        {
            InitializeComponent();

            //List<TreeNode> list = new List<TreeNode>();
            //list.Add(new TreeNode("trqbva da e file"));
            //list.Add(new TreeNode("pak file"));
            //TreeNode tn = new TreeNode("toq pyt fodler",/*ARRAY BRAAT*/ list.ToArray());


            //treeView1.Nodes.Add(tn);

            //List<TreeNode> list2 = new List<TreeNode>();
            //list2.Add(new TreeNode("pak file we"));
            //list2.Add(tn);

            //TreeNode tn2 = new TreeNode("Pak folder we", list2.ToArray());
            //treeView1.Nodes.Add(tn2);

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

            var list = ic.GetAllFilesRecursively(selectedPath);
            
            treeView1.Nodes.Add(PopulateTree(list));
            
         }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //NOT IMPLEMENTED
            //TODO
            //ic.FilePath = treeView1.SelectedNode.Text;
            tbSelectedNode.Text = treeView1.SelectedNode.Text;
        }
    }
}
