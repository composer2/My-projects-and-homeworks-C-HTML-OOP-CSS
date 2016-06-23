using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses
{
    public abstract class Person
    {
        private string firstName;
        private string lastName;
        private int? age;
        private string gender;

        protected Person()
        {
        }

        protected Person(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        protected Person(string firstName, string lastName, int age)
            : this(firstName, lastName)
        {
            this.age = age;
        }

        protected Person(string firstName, string lastName, int age, string gender)
            : this(firstName, lastName, age)
        {
            this.gender = gender;
        }

        protected string FirstName
        {
            get
            {
                return this.firstName;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Cannot be empty");
                }
                this.firstName = value;
            }
        }
        protected string LastName
        {
            get
            {
                return this.lastName;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Cannot be empty");
                }
                this.lastName = value;
            }
        }

        protected int? Age
        {
            get
            {
                return this.age;
            }
            private set
            {
                if (value < 0 || value > 120)
                {
                    throw new ArgumentException("Age must be 0-120");
                }
                this.age = value;
            }
        }
        protected string Gender
        {
            get
            {
                return this.gender;
            }
            private set
            {
                if (value != "male" && value != "female")
                {
                    throw new ArgumentException("Gender must be male or female");
                }
                this.gender = value;
            }
        }

        public override string ToString()
        {
            var person = new StringBuilder();
            person.AppendFormat("{0} {1}", this.firstName, this.lastName);
            person.AppendLine();

            if (this.age != null)
            {
                person.AppendLine("Age: " + this.age);
            }
            if (this.gender != null)
            {
                person.AppendLine("Age: " + this.gender);
            }

            return person.ToString();
        }
    }
}
