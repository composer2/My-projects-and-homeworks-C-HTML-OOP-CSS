using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_Methods_Delegates_Lambda_LINQ
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Course> Courses { get; set; }

        public string SayName()
        {
            return "I am " + this.Name;
        }

        public override string ToString()
        {

            return this.Id + "; Name: " + this.Name + "; Course: " + this.Courses.Count;
        }
    }
}
