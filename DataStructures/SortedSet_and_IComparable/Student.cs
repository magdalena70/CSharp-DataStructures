using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedSet_and_IComparable
{
    public class Student : IComparable<Student>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int CompareTo(Student other)
        {
            return this.Id.CompareTo(other.Id);
        }

        public override string ToString()
        {
            return "{" + this.Id + " : " + this.Name + "}";
        }  

    }
}
