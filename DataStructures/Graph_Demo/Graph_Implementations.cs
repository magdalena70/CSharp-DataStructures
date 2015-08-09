using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph_Demo
{
    class Graph_Implementations
    {
        static void Main()
        {
            // G(V, E) -> V(vertex), E(edges)
            var graph = new Graph(new List<int>[] {
                new List<int> {3, 6}, // vertix 0 is neighbor with 3 and 6
                new List<int> {2, 3, 4, 5, 6}, // vertix 1
                new List<int> {1, 4, 5}, // vertix 2
                new List<int> {0, 1, 5}, // vertix 3
                new List<int> {1, 2, 6}, // vertix 4
                new List<int> {1, 2, 3}, // vertix 5
                new List<int> {0, 1, 4} // vertix 6
            });
        }
    }
}
