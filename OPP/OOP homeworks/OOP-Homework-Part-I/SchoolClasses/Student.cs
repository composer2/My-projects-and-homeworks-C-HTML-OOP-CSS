using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses
{
    public class Student : Person
    {
        private int classNumber;

        public Student(string firstName, string lastName, int classNumber)
            : base(firstName, lastName)
        {
            this.classNumber = classNumber;
        }

        public Student(string firstName, string lastName, int classNumber, int age)
            : base(firstName, lastName, age)
        {
            this.classNumber = classNumber;
        }
        public Student(string firstName, string lastName, int classNumber, int age, string gender)
           : base(firstName, lastName, age, gender)
        {
            this.classNumber = classNumber;
        }
        public int ClassNumber
        {
            get
            {
                return this.classNumber;
            }
            set
            {
                if (value<1)
                {
                    throw new ArgumentException("Class number must be larger than 0");
                }
                this.classNumber = value;
            }
        }

        public override string ToString()
        {
            var student = new StringBuilder();

            student.AppendFormat("Class number: {0}", this.classNumber);
            student.AppendLine();

            return student.ToString();
        }
    }
}
