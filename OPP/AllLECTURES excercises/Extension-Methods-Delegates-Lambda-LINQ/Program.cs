using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_Methods_Delegates_Lambda_LINQ
{
    public delegate int StringDelegate<T>(T value);

    public delegate void SimpleDelegate(string param);
    class Program
    {
        private static void TestMethod(string param)
        {
            Console.WriteLine("Called by delegate");
            Console.WriteLine("I have parameter {0}", param);
        }

        private static int PrintString(string str)
        {
            Console.WriteLine("Str {0}", str);
            return 1;
        }

        private int PrintStringLenght(string value)
        {
            Console.WriteLine("Lenfght {0}", value.Length);
            return 2;
        }

        private static void ListOnChanged(object sender, EventArgs eventArgs)
        {
            Console.WriteLine("ListOnChanged(object sender, EventArgs eventArgs)");
        }

        static void Main()
        {
            ////extension methods -static
            //var str = "Hello extension methods";
            //Console.WriteLine(str.WordCount());
            //var ints = new List<int> { 1, 2, 3, 4, 5 };
            //Console.WriteLine(ints.ToString());
            //Console.WriteLine(ints.ToString<int>());
            //ints.IncreaseWidth(5);
            //Console.WriteLine(ints.ToString<int>());

            ////AnnonymousTypes
            //var myCar = new { Color = "Red", Brand = "BMW", Speed = 100 };
            //Console.WriteLine("My car is {0}  {1} and goes with {2}", myCar.Color, myCar.Brand, myCar.Speed);
            //Console.WriteLine();
            //var p1 = new { X = 3, Y = 5 };
            //var p2 = new { X = 3, Y = 5 };
            //Console.WriteLine(p1);
            //Console.WriteLine(p2);
            //Console.WriteLine(p1 == p2);
            //Console.WriteLine(p1.Equals(p2));
            //Console.WriteLine();
            //var combined = new { P = p1, Q = p2 };
            //Console.WriteLine(combined.P.X);
            //Console.WriteLine();
            //var arr = new[] {
            //    new { X=3,Y=5},
            //    new { X=2,Y=4},
            //    new { X=1,Y=7},
            //};
            //foreach (var item in arr)
            //{
            //    Console.WriteLine("{0}:{1}",item.X,item.Y);
            //}

            ////Simple delegate
            //// Instantiate the delegate
            //SimpleDelegate d = new SimpleDelegate(TestMethod);
            //// The above can be written in a shorter way
            //d = TestMethod;
            //// Invocation of the method, pointed by delegate
            //d("alabala");

            ////multi delegates
            //StringDelegate<string> d2 = Program.PrintString;
            //Program instance = new Program();
            //d2 += instance.PrintStringLenght;
            //d2 += delegate (string str)
            //{
            //    Console.WriteLine("uppercase: {0}", str.ToUpper());
            //    return 3;
            //};
            //int result = d2("Some string value");
            //Console.WriteLine("Result {0}", result);
            //Func<string, int> predefinedIntParse = int.Parse;
            //int number = predefinedIntParse("10");
            //Console.WriteLine(number);
            //Action<object> predefinedAction = Console.WriteLine;
            //predefinedAction(1000);

            ////Events 
            //// Test the ListWithChangedEvent class.
            //var list = new Events();
            //// Add and remove items from the list.
            //Console.WriteLine("----ADD item 1");
            //list.Add("item 1");
            //list.Clear();
            //// Attach method as a listener
            //// list.Changed += new ChangedEventHandler(ListOnChanged);
            //list.Changed += ListOnChanged;
            //// Attach delegate as a listener
            //list.Changed += delegate (object sender, EventArgs args)
            //{
            //    Console.WriteLine("degate(object sender, EventArgs args)");
            //};
            //// Attach anonymous type as a listener
            //list.Changed += (sender, args) => Console.WriteLine("sender, args =>");

            //Console.WriteLine("----add item 2");
            //list.Add("item 2");

            //list.Changed -= ListOnChanged;

            //Console.WriteLine("-------add item 3");
            //list.Add("item 3");

            ////lamda expresion Pet class
            //var list = new List<int>() { 1, 2, 3, 4, 5 };
            //var evenNum = list.FindAll(x => x % 2 == 0);
            //foreach (var item in evenNum)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();
            //list.RemoveAll(x => x > 3);
            //foreach (var item in list)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();
            //var pets = new Pet[]
            //{
            //    new Pet { Name = "Jaro", Age = 1 },
            //    new Pet { Name = "Baro", Age = 7 },
            //    new Pet { Name = "Garo", Age = 6 },
            //    new Pet { Name = "Sharo", Age = 8 }};
            //var sortedPets = pets.OrderBy(x => x.Age);
            //foreach (var item in sortedPets)
            //{
            //    Console.WriteLine("{0} -> {1}", item.Name, item.Age);
            //}
            //Console.WriteLine();
            //list = new List<int> { 20, 1, 4, 8, 9, 44 };
            //evenNum = list.FindAll((i) =>
            //  {
            //      Console.WriteLine("value of i is {0} ", i);
            //      return i % 2 == 0;
            //  });
            //Console.WriteLine("even numbers");
            //foreach (var item in evenNum)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();
            //Func<bool> boolFunc = () => true;
            //Func<int, bool> intFunc = (x) => x < 10;
            //if (boolFunc() && intFunc(5))
            //{
            //    Console.WriteLine("5<10");
            //}
            //var towns = new List<string>() { "Sofia", "Plovdiv", "Varna", "Sopot", "Silistra" };
            //var townsWithS = towns.FindAll(delegate (string town)
            //  {
            //      return town.StartsWith("S");
            //  });
            ////// A short form of the above (with lambda expression)
            ////// List<string> townsWithS = towns.FindAll((town) => town.StartsWith("S"));
            //foreach (var item in townsWithS)
            //{
            //    Console.Write(item+" ");
            //}
            //Console.WriteLine();

            ////Action_And_Func
            //// Action<int> logNumber = Console.WriteLine;
            //Action<int> logNumber = (number) => Console.WriteLine(number);
            //logNumber(5);
            //Action<string, int> logNameAge = (name, age) =>
            //  {
            //      Console.WriteLine("Name " + name);
            //      Console.WriteLine("Age " + age);
            //  };
            //logNameAge("pesho", 21);
            //// Func<string> magic = () => "Magic";
            //Func<string> magic = () =>
            //{
            //    return "Magic";
            //};
            //Console.WriteLine(magic);
            //Func<string, int> parser = int.Parse;
            //int numbers = parser("199");
            //Console.WriteLine(numbers);
            //string[] someStrings= { "Pesho", "Ivaylo", "Gosho", "Niki" };
            //someStrings.Each(Console.WriteLine);
            //someStrings.Each(str =>
            //{
            //    Console.Write(str +" ");
            //});
            //Console.WriteLine();

            ////LINQ-Extenstion-Methods
            //LinqStaticCalls.LinqKeywordsExamples();
            //LinqStaticCalls.LinqExtensionMethodsExamples();

            //Dynamic
            Dynamic.UsingDynamicDemo();
            Dynamic.ExpandoObjectDemo();
        }
    }
}
