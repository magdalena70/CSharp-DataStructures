using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph_Demo
{
    public class Graph
    {
        List<int>[] childNodes;

        public Graph(List<int>[] nodes)
        {
            this.childNodes = nodes;
        }
    }
}
