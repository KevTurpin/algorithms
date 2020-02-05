using System;
using System.Collections.Generic;
using Algorithms.Host.DataStructures;

namespace Algorithms.Host.Traversal
{
    public class BreadthFirstSearch
    {
        public string Traverse(BinaryTree treeNode)
        {
            var q = new Queue<BinaryTree>();
            q.Enqueue(treeNode);

            string result = String.Empty;
            while (q.Count > 0)
            {
                treeNode = q.Dequeue();
                result += $"{treeNode.Data} ";
                
                if (treeNode.Left != null) q.Enqueue(treeNode.Left);
                if (treeNode.Right != null) q.Enqueue(treeNode.Right);
            }

            return result;
        }
    }
}