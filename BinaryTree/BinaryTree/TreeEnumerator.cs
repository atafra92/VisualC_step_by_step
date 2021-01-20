using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class TreeEnumerator<TItem> : IEnumerator<TItem> where TItem : IComparable<TItem>
    {
        private Tree<TItem> currentData = null; //holds a reference to the tree being enumerated
        private TItem currentItem = default(TItem); //holds the value returned by the Currrent property
        private Queue<TItem> enumData = null; //holds the values extracted from the nodes in the tree

        public TreeEnumerator(Tree<TItem> data)
        {
            currentData = data;
        }

        TItem IEnumerator<TItem>.Current => throw new NotImplementedException();

        object IEnumerator.Current => throw new NotImplementedException();

        void IDisposable.Dispose()
        {
            throw new NotImplementedException();
        }

        bool IEnumerator.MoveNext()
        {
            if(enumData == null)
            {
                enumData = new Queue<TItem>();
                Populate(enumData, currentData);
            }

            if(enumData.Count > 0)
            {
                currentData = enumData.Dequeue();
                return true;
            }

            return false;
        }

        /// <summary>
        /// This method walks the binary tree, adding the data it contains to the queue
        /// </summary>
        /// <param name="enumQueue"></param>
        /// <param name="tree"></param>
        private void Populate(Queue<TItem> enumQueue, Tree<TItem> tree)
        {
            if(tree.LeftTree != null)
            {
                Populate(enumQueue, tree.LeftTree);
            }

            enumQueue.Enqueue(tree.NodeData);

            if(tree.RightTree != null)
            {
                Populate(enumQueue, tree.RightTree);
            }
          
        }

        void IEnumerator.Reset()
        {
            throw new NotImplementedException();
        }
    }
}
