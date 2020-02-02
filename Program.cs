using System;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            DoDepthFirstSearch();
            
        }

        static void DoDepthFirstSearch()
        {
            var g = new Graph(4); 

            g.AddEdge(0, 1); 
            g.AddEdge(0, 2); 
            g.AddEdge(1, 2); 
            g.AddEdge(2, 0); 
            g.AddEdge(2, 3); 
            g.AddEdge(3, 3); 

            Console.WriteLine("Following is Depth First Traversal " + 
                              "(starting from vertex 0)");
            g.DFS(0); 
        }
    }
}
