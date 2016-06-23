using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace keepTheObjectStateCorrect
{
    class Person
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
            get {return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cant be empty!");
                }
                if (value.Length<2)
                {
                    throw new ArgumentException("Name too short!-min 2 chars");
                }
                if (value.Length >= 50)
                {
                    throw new ArgumentException("Name too long- shorter than 50 chars");
                }

                foreach (char ch in value)
                {
                    if (!IsLetterAllowedInNames(ch))
                    {
                        throw new ArgumentException("Invalid name- use only letters, space and hypen");
                    }
                }
                this.name=value;
            }
        }
        public int Age
        {
            get { return this.age; }
            set
            {
                if (value<0||value>120)
                {
                    throw new ArgumentException("Invalid age- should be between [0-120].");
                }
                this.age = value;
            }
        }

        private bool IsLetterAllowedInNames(char ch)
        {
            bool IsAllowed = char.IsLetter(ch) || ch == '-' || ch == ' ';
            return IsAllowed;
        }

        static void Main(string[] args)
        {
        }
    }
}
