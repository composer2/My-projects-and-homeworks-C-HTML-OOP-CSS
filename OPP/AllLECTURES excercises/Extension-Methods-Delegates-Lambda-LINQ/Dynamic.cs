using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Dynamic;

namespace Extension_Methods_Delegates_Lambda_LINQ
{
    internal static class Dynamic
    {
        // using dynamic for classes
        public static void UsingDynamicDemo()
        {
            dynamic student = new Student();
            student.Name = "Pesho";
            Console.WriteLine(student.Name);
            // using dynamic without having dynamic all over the place
            int result = Sum<int>(5, 6);
            decimal decResult = Sum<decimal>(15.6M, 10.5M);
            string text = Sum<string>("Pesho ", "e lud");
            Console.WriteLine(result);
            Console.WriteLine(decResult);
            Console.WriteLine(text);
            // using dynamic to compare types
            int compare = Compare(5, 6);
            //// comparing = Compare("pesho", "gosho"); // this causes exception
            Console.WriteLine(compare);
        }
        private static T Sum<T>(dynamic first, dynamic second)
        {
            return first + second;
        }
        // This will not compile: private static T Sum<T>(T first, T second)
        // Neighter this: private static T Sum<T>(object first, object second)
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
        public static void ExpandoObjectDemo()
        {
            // using dynamic expanding object
            dynamic expObj= new ExpandoObject();
            expObj.Result = 5;
            Console.WriteLine("Result: "+expObj.Result);
            expObj.FirstName = "Pesho";
            expObj.LastName = "Goshovski";
            expObj.SayHello = new Func<string>(() => { return "I am " + expObj.FirstName + " " + expObj.LastName; });
            Console.WriteLine(expObj.SayHello());
            // using ExpandoObject as Dictionary<TPropertyName, TPropertyValue>
            var properties = (IDictionary<string, object>)expObj;
            properties.Add("Age", 10);
            properties.Add("SayAge", new Func<string>(()=> { return "My age is " + properties["Age"]; }));
            Console.WriteLine(expObj.SayAge());
            properties.Add("ChangeAge", new Action<int>((age)=> { properties["Age"] = age; }));
            expObj.ChangeAge(20);
            Console.WriteLine(expObj.SayAge());

            foreach (var item in properties)
            {
                Console.WriteLine(item.Key+": "+item.Value);
            }
            // this will not compile:
            // ExpandoObject someObj = new ExpandoObject();
            // someObj.Result = "Pesho";
            // Console.WriteLine(someObj.Result);



        }

    }
}
