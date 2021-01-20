using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class Tree<TItem> where TItem : IComparable<TItem>
    {
        public TItem NodeData { get; set; }
        public Tree<TItem> LeftTree { get; set; } = null;
        public Tree<TItem> RightTree { get; set; } = null;

        public Tree(TItem nodeValue)
        {
            NodeData = nodeValue; //initial node for binary tree
        }

        public void Insert(TItem newItem)
        {
            TItem currentNodeValue = NodeData;
            if(currentNodeValue.CompareTo(newItem) > 0)
            {
                //Insert the new item to left subtree
                if(LeftTree == null)
                {
                    LeftTree = new Tree<TItem>(newItem);
                }
                else
                {
                    LeftTree.Insert(newItem);
                }
            }
            else
            {
                //Insert the new item to right subtree
                if (RightTree == null)
                {
                    RightTree = new Tree<TItem>(newItem);
                }
                else
                {
                    RightTree.Insert(newItem);
                }
            }
        }
        /// <summary>
        /// This method walks the tree, visiting each node in sequence and 
        /// generates a string representation of the data tree contains
        /// </summary>
        /// <returns></returns>
        public string WalkTree()
        {
            string result = "";

            if (LeftTree != null)
            {
                result += LeftTree.WalkTree();
            }

            result += $" {NodeData.ToString() } ";

            if(RightTree != null)
            {
                result += RightTree.WalkTree();
            }

            return result;
        }
    }
}
