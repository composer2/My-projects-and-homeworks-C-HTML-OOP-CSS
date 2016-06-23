using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndWorkers
{
    public class Student : Human
    {

        private int grade;

        public Student(string firstName, string lastName, int grade)
            : base(firstName, lastName)
        {
            this.grade = grade;
        }

        public int Grade
        {
            get
            {
                return this.grade;
            }
            set
            {
                if (value < 1 || value > 12)
                {
                    throw new ArgumentException("Invalid grade-must be 1-12");
                }
                this.grade = value;
            }
        }

        public override string ToString()
        {
            var student = new StringBuilder();

            student.AppendLine("Grade:" + this.grade);

            return base.ToString() + student;
        }
    }
}
