using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Dynamic;

namespace Dynamic
{
   public class Dynamic
    {
        private static void UsingDynamicDemo()
        {
            // using dynamic for classes
            dynamic student = new Student();
            student.Name = "Pesho";
            Console.WriteLine(student.Name);
            // using dynamic without having dynamic all over the place
            int result = Sum<int>(5, 6);
            decimal decimalResult = Sum<decimal>(15.6M, 16.15M);
            string text = Sum<string>("pesho", "gosho");

            Console.WriteLine(result);
            Console.WriteLine(decimalResult);
            Console.WriteLine(text);

            // using dynamic to compare types
            int comparing = Compare(5, 6);
            //// comparing = Compare("pesho", "gosho"); // this causes exception

            Console.WriteLine(comparing);
        }
        // This will not compile: private static T Sum<T>(T first, T second)
        // Neighter this: private static T Sum<T>(object first, object second)
        private static T Sum<T>(dynamic first, dynamic second)
        {
            return first + second;
        }

        // This will not compile: private static int Compare<T>(T first, T second)
        // Neighter this: private static int Compare(object first, object second)
        private static int Compare(dynamic first, dynamic second)
        {
            if (first==second)
            {
                return 0;
            }
            else
            {
                if (first<second)
                {
                    return -1;
                }
                else
                {
                    return 1;
                }
            }
        }
        private static void ExpandoObjectDemo()
        {
            // using dynamic expanding object
            dynamic expObj =new ExpandoObject();
            expObj.Result = 5;
            Console.WriteLine("Result "+expObj.Result);
            expObj.FirstName = "Pesho";
            expObj.LastName = "Peshov";
            expObj.SayHello = new Func<string>(() => { return "I am" + expObj.FirstName + " " + expObj.LastName; });
            Console.WriteLine(expObj.SayHello());

            // using ExpandoObject as Dictionary<TPropertyName, TPropertyValue>
            var properties = (IDictionary<string, object>)expObj;
            properties.Add("Age", 10);
            properties.Add("SayAge", new Func<String>(() => { return "My age is " + properties["Age"]; }));
            Console.WriteLine(expObj.SayAge());

            foreach (var pair in properties)
            {
                Console.WriteLine(pair.Key+" : "+pair.Value);
            }
            // this will not compile:
            // ExpandoObject someObj = new ExpandoObject();
            // someObj.Result = "Pesho";
            // Console.WriteLine(someObj.Result);
        }
        static void Main(string[] args)
        {
            UsingDynamicDemo();
            ExpandoObjectDemo();
        }
    }
}
