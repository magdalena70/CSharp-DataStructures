using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraverseGraph
{
    public class FindConnectedComponents
    {
        private static List<int>[] graph = 
        {
            new List<int>{ 3, 6 },
            new List<int>{ 3, 4, 5, 6 },
            new List<int>{ 8 },
            new List<int>{ 0, 1, 5 },
            new List<int>{ 1, 6 },
            new List<int>{ 1, 3 },
            new List<int>{ 0, 1, 4},
            new List<int>{ },
            new List<int>{ 2 }
        };
        private static List<int>[] graphReadLine;
        private static bool[] visitedNode;

        public static void Main()
        {
            //------Part 1--------//

            visitedNode = new bool[graph.Length];
            PrintGraph(graph);

            //------Part 2--------//

            int graphSize = int.Parse(Console.ReadLine());
            graphReadLine = new List<int>[graphSize];
            visitedNode = new bool[graphSize];
            for (int row = 0; row < graphSize; row++)
            {
                graphReadLine[row] = new List<int>();
                string neighboursLine = Console.ReadLine();
                string[] neighboursSplit = neighboursLine
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                int[] neighbours = new int[neighboursSplit.Length];
                for (int index = 0; index < neighbours.Length; index++)
                {
                    neighbours[index] = int.Parse(neighboursSplit[index]);
                    graphReadLine[row].Add(neighbours[index]);
                }
            }

            PrintGraph(graphReadLine);
            
        }

        private static void PrintGraph(List<int>[] g)
        {
            for (int i = 0; i < g.Length; i++)
            {
                if (!visitedNode[i])
                {
                    Console.Write("Connected component: ");
                    DepthFirstSearchGraphs(i);
                    Console.WriteLine();
                }
            }
        }

        private static void DepthFirstSearchGraphs(int node)
        {
            if (!visitedNode[node])
            {
                visitedNode[node] = true;
                foreach (var child in graph[node])
                {
                    DepthFirstSearchGraphs(child);
                }

                Console.Write("{0} ", node);
            }
        }
    }
}
