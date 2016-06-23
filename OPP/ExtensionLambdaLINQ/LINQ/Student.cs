using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class Student
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<Course> Course {get; set;}

        public override string ToString()
        {
            return this.Id + "; Name: " + this.Name + "; Course: " + this.Course.Count;
        }
    }
}
