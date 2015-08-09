using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees_Implementations
{
    class Trees_Implementations
    {
        static void Main()
        {
            Tree<int> tree = 
                new Tree<int>(7,
                    new Tree<int>(12),
                    new Tree<int>(2,
                        new Tree<int>(18)
                    ),
                    new Tree<int>(55),
                    new Tree<int>(3),
                    new Tree<int>(276,
                        new Tree<int>(10),
                        new Tree<int>(78,
                            new Tree<int>(1078),
                            new Tree<int>(11)
                        ),
                new Tree<int>(2)
                )
            );

            Console.WriteLine("Tree<int> tree = ");
            tree.Print();

            Console.WriteLine("Depth-First Search (DFS) ->");
            DepthFirstSearch(tree);
        }

        private static void DepthFirstSearch(Tree<int> node)
        {
            foreach (var childNode in node.Children)
            {
                DepthFirstSearch(childNode);
            }

            Console.Write(" {0} ", node.Value);
        }

    }
}
