using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_Demo
{
    class SequenceN
    {
        static void Main()
        {
            int n = 3;
            int p = 16;

            var sequenceN = new Queue<int>();
            sequenceN.Enqueue(n);
            var indexP = 1;
            while (sequenceN.Count > 0)
            {
                int currentElement = sequenceN.Dequeue();
                if (currentElement == p)
                {
                    Console.WriteLine("Index of P = {0}", indexP);
                    break;
                }
                else
                {
                    sequenceN.Enqueue(currentElement + 1);
                    sequenceN.Enqueue(currentElement * 2);
                }
                indexP++;
            }
        }
    }
}
