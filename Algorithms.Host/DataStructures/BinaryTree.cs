using System.Collections.Generic;

namespace Algorithms.Host.DataStructures
{
    public class BinaryTree
    {
        public BinaryTree Left { get; }
        public BinaryTree Right { get; }
        public string Data { get; }

        public BinaryTree(string data, BinaryTree left = null, BinaryTree right = null)
        {
            Data = data;
            Left = left;
            Right = right;
        }
    }
}