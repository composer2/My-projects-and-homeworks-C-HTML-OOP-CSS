using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    class AnimalHierarchy
    {
        static void Main(string[] args)
        {
            //list of Cats
            var cats = new List<Cat>()
            {
                new Cat("Wannabe", 2, "male"),
                new Cat("Mark", 0, "male"),
                new Cat("Wiskas", 3, "male"),
                new Cat("Lily", 1, "female"),
                new Cat("Hola", 10, "female")
            };

            //list of Kittens
            var kittens = new List<Kitten>()
            {
                new Kitten("Mony", 3),
                new Kitten("Tusy", 2),
                new Kitten("Wendy", 3),
                new Kitten("Friko", 1),
                new Kitten("Sunny", 5)
            };

            var tomcats = new List<Tomcat>()
            {
                new Tomcat("Gosho", 2),
                new Tomcat("Tosho", 7),
                new Tomcat("Bojo", 6),
                new Tomcat("Lara", 8),
                new Tomcat("Jeko", 10)
            };

            var dogs = new List<Dog>()
            {
                new Dog("Bars", 3, "male"),
                new Dog("Stanka", 4, "female"),
                new Dog("Djack", 12, "male"),
                new Dog("Fred", 1, "male"),
                new Dog("Rita", 10, "female")
            };

            //list of Frogs
            var frogs = new List<Frog>()
            {
                new Frog("Jdrep", 3, "male"),
                new Frog("Djuk", 2, "male"),
                new Frog("Jela", 8, "female"),
                new Frog("Jliva", 4, "female"),
                new Frog("Jelio", 7, "female")
            };

            //calculates avarages
            var catAverage = Animal.AverageAge(cats);
            var dogsAverage = Animal.AverageAge(dogs);
            var kittenAverage = Animal.AverageAge(kittens);
            var tomcatAverage = Animal.AverageAge(tomcats);
            var frogsAverage = Animal.AverageAge(frogs);

            Console.WriteLine("Cats: ");
            Console.WriteLine(new string('*', 40));
            Animal.PrintAnimals(cats);
            Console.WriteLine();
            Console.WriteLine("Cats say: ");
            Console.WriteLine(new string('*', 40));
            cats[0].MakeSound();
            Console.WriteLine(new string('*', 40));
            Console.WriteLine("average age: {0:f2}", catAverage);
            Console.WriteLine();

            Console.WriteLine("Dogs: ");
            Console.WriteLine(new string('*', 40));
            Animal.PrintAnimals(dogs);
            Console.WriteLine();
            Console.WriteLine("Dogs say: ");
            Console.WriteLine(new string('*', 40));
            dogs[0].MakeSound();
            Console.WriteLine(new string('*', 40));
            Console.WriteLine("average age: {0:f2}", dogsAverage);
            Console.WriteLine();

            Console.WriteLine("Kitten: ");
            Console.WriteLine(new string('*', 40));
            Animal.PrintAnimals(kittens);
            Console.WriteLine();
            Console.WriteLine("Kitten say: ");
            Console.WriteLine(new string('*', 40));
            kittens[0].MakeSound();
            Console.WriteLine(new string('*', 40));
            Console.WriteLine("average age: {0:f2}", kittenAverage);
            Console.WriteLine();

            Console.WriteLine("Tomcat: ");
            Console.WriteLine(new string('*', 40));
            Animal.PrintAnimals(tomcats);
            Console.WriteLine();
            Console.WriteLine("Tomcat say: ");
            Console.WriteLine(new string('*', 40));
            tomcats[0].MakeSound();
            Console.WriteLine(new string('*', 40));
            Console.WriteLine("average age: {0:f2}", tomcatAverage);
            Console.WriteLine();

            Console.WriteLine("Frog: ");
            Console.WriteLine(new string('*', 40));
            Animal.PrintAnimals(frogs);
            Console.WriteLine();
            Console.WriteLine("Frogs say: ");
            Console.WriteLine(new string('*', 40));
            frogs[0].MakeSound();
            Console.WriteLine(new string('*', 40));
            Console.WriteLine("average age: {0:f2}", frogsAverage);
        }
    }
}
