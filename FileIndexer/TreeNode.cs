using System.Collections.Generic;
using System;

namespace FileIndexer
{
    public class TreeNode<T>
    {
        List<TreeNode<T>> Children = new List<TreeNode<T>>();
        T Item { get; set; }

        public TreeNode(T item)
        {
            Item = item;
        }
        public TreeNode(TreeNode<T> item)
        {
            Item = item.Item;
            Children = item.Children;
        }

        public TreeNode<T> AddChild(T item)
        {
            TreeNode<T> nodeItem = new TreeNode<T>(item);
            Children.Add(nodeItem);
            return nodeItem;
        }
        public TreeNode<T> AddChild(TreeNode<T> item)
        {
            TreeNode<T> nodeItem = new TreeNode<T>(item);
            Children.Add(nodeItem);
            return nodeItem;
        }
       
        public T GetCurrentNodeData()
        {
            return Item;
        }
        public List<TreeNode<T>> GetCurrentNodeChildren()
        {
            return Children;
        }

        public T SearchItem(T item)
        {
            if (Item.Equals(item)) { return Item; }
            else
            {
                foreach (TreeNode<T> child in Children)
                {
                    if (child.Equals(SearchItem(item))) { return child.GetCurrentNodeData(); }
                }
            }
            throw new Exception("Element not found.");
        }
    }
}
