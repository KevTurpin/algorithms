using System;
using System.Collections.Generic;

namespace Algorithms
{
    public class Graph 
    { 
        private readonly int _vertices; // No. of vertices array of lists for adjacency List Representation 
        private List<int>[] _adjLists; 

        #region Constructors
        public Graph(int vertices) 
        { 
            _vertices = vertices; 
            _adjLists = new List<int>[vertices];
            
            for (int i = 0; i < vertices; ++i) 
                _adjLists[i] = new List<int>(); 
        } 
        #endregion
 
        public void AddEdge(int verticeIndex, int edgeValue) 
        { 
            _adjLists[verticeIndex].Add(edgeValue); 
        } 

        public void DFS(int v) 
        { 
            bool[] visited = new bool[_vertices];
            DFSUtil(v, visited); 
        } 
        
        public void DFSUtil(int v, bool[] visited) 
        { 
            visited[v] = true; 
            Console.Write($"{v} ");  
 
            var vList = _adjLists[v]; 
            foreach (var n in vList)
            { 
                if (visited[n]) continue;
                
                DFSUtil(n, visited); 
            } 
        } 
    } 
}