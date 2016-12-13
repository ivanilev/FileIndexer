using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileIndexer.Controller
{
    public class IndexerController
    {
        private FileSystemInfo selectedFile = null;
        public FileSystemInfo SelectedFile
        {
            get
            {
                return selectedFile;
            }

            set
            {
                selectedFile = value;
            }
        }

        private TreeNode<FileSystemInfo> _tree;
        public TreeNode<FileSystemInfo> Tree
        {
            get { return _tree; }
            private set { _tree = value; }
        }

        private Dictionary<string, FileSystemInfo> _myDict = new Dictionary<string, FileSystemInfo>();
        public Dictionary<string, FileSystemInfo> MyDict
        {
            get
            {
                return _myDict;
            }

            set
            {
                _myDict = value;
            }
        }

        /// <summary>
        /// Iterates through a folder and indexes all files and folders inside.
        /// </summary>
        /// <param name="filepath">The full file path to the folder.</param>
        /// <returns>Returns a Tree of all files and folders inside.</returns>
        public TreeNode<FileSystemInfo> GetAllFilesRecursively(string filepath)
        {
            //If the path doesn't exist stop execution
            if (!Directory.Exists(filepath))
                return null;

            //Get the root directory
            DirectoryInfo rootDirectory = new DirectoryInfo(filepath);

            //Create a tree to be returned as the result
            TreeNode<FileSystemInfo> myTreeResult = new TreeNode<FileSystemInfo>(rootDirectory);

            //Get all files and folders inside
            List<FileSystemInfo> currentNodeFilesAndFoldersList = new List<FileSystemInfo>();
            currentNodeFilesAndFoldersList.AddRange(rootDirectory.GetFileSystemInfos());

            //Add the root folder as well, this is useful only during the first iteration
            if (!MyDict.ContainsKey(filepath))
                MyDict.Add(filepath, rootDirectory);


            //Iterate through all files and folders in the current folder
            foreach (FileSystemInfo item in currentNodeFilesAndFoldersList)
            {
                //Index the file or folder in a dictionary
                MyDict.Add(item.FullName, item);

                //If it's a file add it directly
                if (item.GetType() == typeof(FileInfo))
                {
                    myTreeResult.AddChild(item);
                }
                //If it's a folder - iterate through it, save the result in a Treenode<FileSystemInfo> type and add that node to the main tree.
                else
                {
                    TreeNode<FileSystemInfo> subTree = GetAllFilesRecursively(item.FullName);
                    myTreeResult.AddChild(subTree);
                }
            }

            return Tree = myTreeResult;
        }

        /// <summary>
        /// Retrieves information about a file or folder in string format.
        /// </summary>
        /// <param name="DataInfo">A file or folder.</param>
        /// <returns>Information in the form of string.</returns>
        public string GetFileInfo(FileSystemInfo DataInfo)
        {


            StringBuilder result = new StringBuilder();
            if (DataInfo.Exists == false) { return string.Empty; }


            result.Append("Creation time:\t");//Some lines use a single "\t" and others double "\t\t".
            result.AppendLine(DataInfo.CreationTime.ToString()); //A tab character will align text to the next tab stop, which is about 8 characters. 
            result.AppendLine();


            result.Append("Directory:\t\t");
            if (DataInfo.GetType() == typeof(DirectoryInfo))
            {
                DirectoryInfo di = DataInfo as DirectoryInfo;
                result.AppendLine(di.FullName);
            }
            else
            {
                FileInfo fi = DataInfo as FileInfo;
                result.AppendLine(fi.Directory.FullName);
            }
            result.AppendLine();

            result.Append("Name:\t\t");
            result.AppendLine(DataInfo.Name);
            result.AppendLine();

            result.Append("Last used:\t");
            result.AppendLine(DataInfo.LastAccessTime.ToString());
            result.AppendLine();


            result.Append("Read only:\t");
            if (DataInfo.GetType() == typeof(FileInfo)) //Only if it's a file extentions will be displayed.
            {
                FileInfo fi = DataInfo as FileInfo;
                result.AppendLine(fi.IsReadOnly.ToString());
                result.AppendLine();

                result.Append("Extention:\t\t");
                result.AppendLine(fi.Extension.ToString());
            }
            else
            {
                DirectoryInfo di = DataInfo as DirectoryInfo;
                result.AppendLine(di.Attributes.HasFlag(FileAttributes.ReadOnly).ToString());
            }
            result.AppendLine();

            return result.ToString();
        }

        public bool IsImage(FileSystemInfo DataInfo)
        {
            if (DataInfo.GetType() == typeof(DirectoryInfo))
                return false;

            FileInfo file = DataInfo as FileInfo;

            List<string> extentions = new List<string>(new string[] { ".JPG", ".JPE", ".BMP", ".GIF", ".PNG" });

            if (!extentions.Contains(file.Extension.ToUpper()))
                return false;


            return true;
        }
    }
}
