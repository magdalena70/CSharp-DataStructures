using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedSet_and_IComparable
{
    class Program
    {
        static void Main(string[] args)
        {
            var sortedStudentSet = new SortedSet<Student>();
            Random random = new Random();
            for (int i = 0; i < 20; i++)
            {
                var student = new Student();
                student.Name = "Name" + random.Next(100);
                student.Id = random.Next(50000);
                sortedStudentSet.Add(student);
            }

            sortedStudentSet.ToList().ForEach(Console.WriteLine);
        }
    }
}
