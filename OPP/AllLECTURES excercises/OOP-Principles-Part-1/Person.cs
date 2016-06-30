namespace OOP_Principles_Part_1
{
using System;
internal    class Person
    {
        private string name;
        private int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value==null)
                {
                    throw new ArgumentException("Invalid name");
                }
                this.name = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value < 0 || value > 120)
                {
                    throw new ArgumentOutOfRangeException("Invalid person age.");
                }
                this.age = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Person(name={0}, age={1})",
            this.name, this.age);
        }
    }
}
