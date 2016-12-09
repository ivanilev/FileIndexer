using System;
using System.Collections.Generic;
using System.IO;

namespace FileIndexer.Controller
{
    public class IndexerController
    {
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
    }
}
