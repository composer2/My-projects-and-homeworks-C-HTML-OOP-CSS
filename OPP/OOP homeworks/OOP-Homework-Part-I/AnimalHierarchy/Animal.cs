using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    public abstract class Animal : ISound
    {
        private string name;
        private int age;
        private string sex;

        protected Animal(string name, int age, string sex)
        {
            this.name = name;
            this.age = age;
            this.sex = sex;
        }

        protected string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name can't be empty");
                }
                this.name = value;
            }
        }

        protected int Age
        {
            get
            {
                return this.age;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age must a positive number");
                }
                this.age = value;
            }
        }

        protected string Sex
        {
            get
            {
                return this.sex;
            }
            private set
            {
                if (value != "male" && value != "female")
                {
                    throw new ArgumentException("Gender must be male or female");
                }
                this.sex = value;
            }
        }

        public static double AverageAge(IEnumerable<Animal> animals)
        {
            double average = animals.Average(x => x.age);
            return average;
        }

        public static void PrintAnimals(IEnumerable<Animal> animals)
        {
            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
                Console.WriteLine();
            }
        }

        public override string ToString()
        {
            var animal = new StringBuilder();
            animal.AppendFormat("Animal: {0}",this.GetType().Name);
            animal.AppendLine();
            animal.AppendFormat("Name: {0}",this.name);
            animal.AppendLine();
            animal.AppendFormat("Age: {0}", this.age);
            animal.AppendLine();
            animal.AppendFormat("Gender: {0}", this.sex);

            return animal.ToString(); 
        }

        public virtual void MakeSound()
        {
            Console.WriteLine(this.name+" made a sound.");
        }
    }
}
