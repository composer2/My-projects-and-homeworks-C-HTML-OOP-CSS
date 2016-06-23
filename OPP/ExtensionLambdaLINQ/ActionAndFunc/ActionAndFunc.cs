using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionAndFunc
{
    public static class ActionAndFunc
    {
        public static void Each<T>(this IEnumerable<T> collection, Action<T> action)
        {
            foreach (var item in collection)
            {
                action(item);
            }
        }
        public static void Main(string[] args)
        {
            // Action<int> logNumber = Console.WriteLine;
            Action<int> logNumber = (number) => Console.WriteLine(number);
            logNumber(5);

            Action<string, int> longNameAge = (name, age) =>
              {
                  Console.WriteLine("Name: " + name);
                  Console.WriteLine("Age: " + age);
              };
            longNameAge("Pesho", 21);

            // Func<string> magic = () => "Magic";
            Func<string> magic=() =>
             {
                 return "Magic";
 
             };
            Console.WriteLine(magic());

            Func<string, int> parser = int.Parse;
            int someNumber = parser("50");
            Console.WriteLine(someNumber);

            string[] someStr = {"Pesho","Ivaylo","Gosho","Niki" };
            someStr.Each(Console.WriteLine);
            someStr.Each(str =>
            {
                Console.Write(str+" ");
            });
            Console.WriteLine();
             //Array.ForEach(someStr, Console.WriteLine);
        }
    }
}
