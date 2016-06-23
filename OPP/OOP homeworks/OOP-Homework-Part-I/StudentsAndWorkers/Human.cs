using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndWorkers
{
     public abstract class Human
    {
        private string firstName;
        private string lastName;

        protected Human() { }

        protected Human(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cant be empty");
                }
                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cant be empty");
                }
                this.lastName = value;
            }
        }

        public override string ToString()
        {
            var human = new StringBuilder();

            human.AppendFormat("{0} {1}",this.firstName,this.lastName);
            human.AppendLine();

            return human.ToString();
        }
    }
}
