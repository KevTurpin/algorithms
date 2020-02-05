using System;
using System.Linq;
using Algorithms.Host.DataStructures;
using Algorithms.Host.Traversal;

namespace Algorithms.Host
{
    class Program
    {
        static void Main(string[] args)
        {
            DoJamesTests();
            DoGraphTestAsInt();
            DoGraphTestAsStrings();
            DoBreadthFirstSearchOfBinaryTree();
            Console.ReadKey(); 
        }

        static void DoJamesTests()
        {
            //Given 2 arrays, find the common values in said arrays
            int[] listA = {1, 2, 3, 4, 5, 6};
            int[] listB = {3, 5, 6, 8, 9, 10};

            var result1 = JamesQuestion1.UseTheLanguageALittle(listA, listB).ToArray();
            Console.WriteLine($"UseTheLanguageALittle {string.Join(" ", result1)}" ); 
            
            var result2 = JamesQuestion1.UseTheLanguageMore(listA, listB).ToArray();
            Console.WriteLine($"UseTheLanguageMore {string.Join(" ", result2)}" ); 
            
            var result3 = JamesQuestion1.UseMinimumLanguageFeatures(listA, listB).ToArray();
            Console.WriteLine($"UseMinimumLanguageFeatures {string.Join(" ", result3)}" );                                              
            Console.WriteLine();
        }
        
        static void DoGraphTestAsInt() 
        { 
            var g = new Graph<int>(0, 1, 2, 3); 

            g.AddEdge(0, 1); 
            g.AddEdge(0, 2); 
            g.AddEdge(1, 2); 
            g.AddEdge(2, 0); 
            g.AddEdge(2, 3); 
            g.AddEdge(3, 3);

            var searchAlgorithm = new DepthFirstSearch<int>();
            var result = searchAlgorithm.DoSearch(g, 2);
            
            Console.WriteLine($"DepthFirstSearch On a graph int: {result}");
        }
        
        static void DoGraphTestAsStrings() 
        {
            var g = new Graph<string>("A", "B", "C", "D", "E", "F"); 

            g.AddEdge("A", "B"); 
            g.AddEdge("A", "C"); 
            g.AddEdge("A", "D"); 
            g.AddEdge("B", "A");
            g.AddEdge("B", "C"); 
            g.AddEdge("B", "D");
            g.AddEdge("C", "E");
            g.AddEdge("D", "E");
            g.AddEdge("E", "F");
            g.AddEdge("F", "F");
            
            var searchAlgorithm = new DepthFirstSearch<string>();
            var result = searchAlgorithm.DoSearch(g, "A");
            Console.WriteLine($"DepthFirstSearch on a Graph of string: {result}");
            
        }

        static void DoBreadthFirstSearchOfBinaryTree()
        {
            var tree = new BinaryTree("A",
                new BinaryTree("B",
                    new BinaryTree("C"), new BinaryTree("D")),
                new BinaryTree("E",
                    new BinaryTree("F"), new BinaryTree("G"
                        , new BinaryTree("H"))));

            var searchAlgorithm = new BreadthFirstSearch();
            
            var result = searchAlgorithm.Traverse(tree);
            
            Console.WriteLine($"BreadthFirstSearch on a BinaryTree: {result}");
        }
        
    }
}