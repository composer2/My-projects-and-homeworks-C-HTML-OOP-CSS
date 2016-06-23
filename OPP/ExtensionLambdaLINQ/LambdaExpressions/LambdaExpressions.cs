using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions
{
    class LambdaExpressions
    {
        static void Main(string[] args)
        {
            var list = new List<int> { 1, 2, 3, 4, 5 };
            var evenNumbers = list.FindAll(x => (x % 2) == 0);
            foreach (var num in evenNumbers)
            {
                Console.WriteLine("{0}", num);
            }

            Console.WriteLine();
            list.RemoveAll(x => x > 3);
            foreach (var num in list)
            {
                Console.WriteLine("{0}", num);
            }
            Console.WriteLine();
            var pets = new Pet[] {
                           new Pet { Name = "Sharo", Age = 8 },
                           new Pet { Name = "Rex", Age = 4 },
                           new Pet { Name = "Strela", Age = 1 },
                           new Pet { Name = "Odin", Age = 5 }
                                };
            var sortedPet = pets.OrderBy(p => p.Age);
            foreach (var pet in sortedPet)
            {
                Console.WriteLine("{0} -> {1}", pet.Name, pet.Age);
            }
            Console.WriteLine();

            list = new List<int>() { 20, 1, 4, 8, 9, 44 };
            // Process each argument with code statements
            evenNumbers = list.FindAll(i =>
            {
                Console.WriteLine("value of i is {0}", i);
                return (i % 2 == 0);
            });
            Console.WriteLine("Here are your even numbers:");
            foreach (var even in evenNumbers)
            {
                Console.WriteLine("{0} ", even);
            }
            Console.WriteLine();

            Func<bool> boolFunc = () => true;
            Func<int, bool> intFunc = (x) => x < 10;
            if (boolFunc() && intFunc(5))
            {
                Console.WriteLine("5 < 10");
            }
            var towns = new List<string>() { "Sofia", "Plovdiv", "Varna", "Sopot", "Silistra" };
            var townsWithS = towns.FindAll(delegate (string town)
              {
                  return town.StartsWith("S");
              });
            //// A short form of the above (with lambda expression)
            //// List<string> townsWithS = towns.FindAll((town) => town.StartsWith("S"));

            foreach (string town in townsWithS)
            {
                Console.WriteLine(town);
            }

        }
    }
}
