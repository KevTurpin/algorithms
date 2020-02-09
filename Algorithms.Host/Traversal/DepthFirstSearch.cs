using System;
using System.Collections.Generic;
using Algorithms.Host.DataStructures;

namespace Algorithms.Host.Traversal
{
    public class DepthFirstSearch<TNode>
    {
        private Graph<TNode> _graph;
        
        public string DoSearch(Graph<TNode> graph, TNode startingFrom)
        {
            _graph = graph;
            var startingIndex = graph.IndexOf(startingFrom);
            bool[] visited = new bool[graph.Length]; 
            
            DoSearch(startingIndex, visited);
            return result;
        } 
        private string result = String.Empty;
        private void DoSearch(int index, bool[] visited) 
        {
            visited[index] = true; 
            result += $"{_graph.Nodes[index]} "; 

            List<TNode> nodeList = _graph.Edges[index]; 
            
            foreach (var n in nodeList)
            {
                var ni = _graph.IndexOf(n);
                if (!visited[ni]) DoSearch(ni, visited); 
            } 
        } 

    }
}