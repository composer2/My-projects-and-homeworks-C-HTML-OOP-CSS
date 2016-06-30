namespace PersonTest
{
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    internal class Person
    {
        private string name;
        private int? age;

        public Person(string name, int? age=null)
        {
            this.name = name;
            this.age = age;
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be empty or null");
                }
                this.name = value;
            }
        }
        public int? Age
        {
            get { return this.age; }
            private set
            {
                if (value < 0||value>120)
                {
                    throw new ArgumentException("Age must be 0-120");
                }
                this.age = value;
            }
        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine("Name: " + this.name);
            if (this.age==null)
            {
                sb.AppendLine("Age: unknown");
            }
            else
            {
                sb.AppendLine("Age: " + this.age);
            }
            return sb.ToString();
        }
    }
}
