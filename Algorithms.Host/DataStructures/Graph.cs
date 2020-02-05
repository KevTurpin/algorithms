using System; 
using System.Collections.Generic;
using System.Linq;

namespace Algorithms.Host.DataStructures
{
    public class Graph<TNode>
    {
        private readonly List<TNode>[] _edges;
        private readonly TNode[] _nodes;
        
        #region Constructors
        public Graph(params TNode[] nodes)
        {
            _nodes = nodes;
            _edges = new List<TNode>[nodes.Length];

            for (int i = 0; i < nodes.Length; ++i)
            {
                _edges[i] = new List<TNode>();
            }
        }
        #endregion
        
        public void AddEdge(TNode nodeA, TNode nodeB)
        {
            var indexA = Array.IndexOf(_nodes, nodeA);
            var indexB = _nodes.Any(p => p.Equals(nodeB));

            if (indexA == -1 || indexB == false)
            {
                throw new InvalidOperationException();
            }
            _edges[indexA].Add(nodeB); 
        }
        
        public int Length => _nodes.Length;
        public int IndexOf(TNode startingFrom) => Array.IndexOf(_nodes, startingFrom);
        public TNode[] Nodes => _nodes;
        public List<TNode>[] Edges => _edges;
        
    }
}