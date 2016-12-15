using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace FileIndexer
{
    public partial class FileIndex : Form
    {
        public Controller.IndexerController indexController = new Controller.IndexerController();

        public FileIndex()
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
            {
                treeView1.Nodes.Clear();
                indexController.MyDict.Clear();
                indexController.Tree.GetCurrentNodeChildren().Clear();
                indexController.SelectedFile = null;
            }
                

            try
            {
                treeView1.Nodes.Add(PopulateTree(indexController.GetAllFilesRecursively(selectedPath)));
            }

            catch(UnauthorizedAccessException ex)
            {
                MessageBox.Show(ex.Message);
                btnSelectFolder.Focus();
            }
            catch(Exception)
            {
                MessageBox.Show("An error has occured, please try again!");
                btnSelectFolder.Focus();
            }


            btnSearch.Enabled = true;
            tbSearch.Enabled = true;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            FileSystemInfo fsi;
            string selectedNodeFullFilePath = string.Empty;

            //If the selected note (file or folder) is found in the controller's dictionary - assign its value to "selectedNodeFullFilePath"
            if (indexController.MyDict.Any(kvp => kvp.Key.Contains(treeView1.SelectedNode.Text)))
            {
                selectedNodeFullFilePath = indexController.MyDict.Keys.FirstOrDefault(x => x.EndsWith(treeView1.SelectedNode.Text));
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
            try
            {
                string searchString = tbSearch.Text;

                if (string.IsNullOrEmpty(tbSearch.Text))
                    throw new Exception("Item not found"); 

                string fullFilePath = indexController.MyDict.Keys.FirstOrDefault(x => x.Contains(searchString));

                if (string.IsNullOrEmpty(fullFilePath))
                    throw new Exception("Item not found"); 


                FileSystemInfo foundItem;


                bool itworks = indexController.MyDict.TryGetValue(fullFilePath, out foundItem);

                if (!itworks)
                    throw new Exception("Item not found"); 

                indexController.SelectedFile = foundItem;
                tbSelectedNode.Text = foundItem.FullName;
                tbFileInfo.Text = indexController.GetFileInfo(indexController.SelectedFile);
                treeView1.ExpandAll();

                treeView1.SelectedNode = treeView1.Nodes.Find(foundItem.Name, true)[0];
            }
            catch(Exception ex)
            {
                tbSearch.Text = ex.Message;
                tbSearch.Focus();
                return;
            }
           
        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            try
            {
                TreeNode tn = treeView1.GetNodeAt(e.Location);
                string fullImageFilePath = indexController.MyDict.Keys.FirstOrDefault(x => x.Contains(tn.Text));

                ShowImage(new FileInfo(fullImageFilePath));
            }
            catch (Exception)
            {
                return;
            }
        }

        private void tbFileInfo_DoubleClick(object sender, EventArgs e)
        {
            if (ShowImage(indexController.SelectedFile))
            {
                tbFileInfo.Visible = false;
                tbFileInfo.Enabled = false;

                pbFileImage.Visible = true;
                pbFileImage.Enabled = true;
            }
        }

        private void pbFileImage_DoubleClick(object sender, EventArgs e)
        {
            tbFileInfo.Visible = true;
            tbFileInfo.Enabled = true;

            pbFileImage.Visible = false;
            pbFileImage.Enabled = false;

        }

        private void tsmOpenFile_Click(object sender, EventArgs e)
        {
            string result = indexController.OpenFile(indexController.SelectedFile.FullName);

            if (!string.IsNullOrEmpty(result))
                MessageBox.Show("Error!" + Environment.NewLine + result);
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // Point where the mouse is clicked.
                Point p = new Point(e.X, e.Y);

                // Get the node that the user has clicked.
                TreeNode node = treeView1.GetNodeAt(p);

                if (node != null)
                {
                    //IndexController.SelectedFile is now the file in the right clicked node .
                    FileSystemInfo file = GetFileFromNode(node);
                    if (file != null)
                        indexController.SelectedFile = file;

                    //Finally, show node.
                    cmsNodeClick.Show(treeView1, p);
                }
            }
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
                    list[list.Count - 1].Name = child.GetCurrentNodeData().Name;
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
                        list[list.Count - 1].Name = child.GetCurrentNodeData().Name;
                    }
                    else
                    {
                        list.Add(PopulateTree(child));
                        list[list.Count - 1].Name = child.GetCurrentNodeData().Name;
                    }
                }
                return new TreeNode(tree.GetCurrentNodeData().Name, list.ToArray());
            }
        }
        
        /// <summary>
        /// If the file given as parameter is an image - it's displayed it in the right panel.
        /// </summary>
        /// <param name="file">The image to be displayed.</param>
        /// <returns>Returns true if everything is OK and false if errors occur.</returns>
        private bool ShowImage(FileSystemInfo file)
        {


            if (!indexController.IsImage(file))
                return false;

            try
            {
                pbFileImage.Image = Image.FromFile(file.FullName);
            }
            catch (Exception)
            {
                return false;
            }

            tbFileInfo.Visible = false;
            tbFileInfo.Enabled = false;

            pbFileImage.Visible = true;
            pbFileImage.Enabled = true;

            pbFileImage.Image = Image.FromFile(file.FullName);

            return true;
        }


        private FileSystemInfo GetFileFromNode(TreeNode node)
        {
            string fullFilePath = indexController.MyDict.Keys.FirstOrDefault(x => x.Contains(node.Name));
            FileSystemInfo result;
            bool itworks = indexController.MyDict.TryGetValue(fullFilePath, out result);

            if (itworks)
                return result;
            else
                return null;
        }

        #endregion


    }
}