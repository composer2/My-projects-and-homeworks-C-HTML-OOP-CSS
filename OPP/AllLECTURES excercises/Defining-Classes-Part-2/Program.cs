using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using Defining_Classes_Part_2;

[AttributeUsage(AttributeTargets.Struct |
  AttributeTargets.Class | AttributeTargets.Interface,
  AllowMultiple = true)]
public class AuthorAttribute : System.Attribute
{
    public string Name { get; private set; }

    public AuthorAttribute(string name)
    {
        this.Name = name;
    }
}

[Author("Nikolay Kostov")]
[Author("Doncho Minkov")]
[Author("Ivaylo Kenov")]
[Author("Evlogi Hristov")]



class Program
{
    [DllImport("user32.dll", EntryPoint = "MessageBox")]
    public static extern int ShowMessageBox(int hWnd, string text, string caption, int type);

    static void Main(string[] args)
    {
        ////static method
        //Console.WriteLine(SqrtPrecalculated.GetSqrt(254));     

        ////structures color edges point square
        //var square = new Square(
        //    new Point() { X = 5, Y = -3 },
        //    7,
        //    new Color() { RedValue = 55, GreenValue = 55, BlueValue=0 },
        //    new Color() { RedValue = 0, GreenValue = 155, BlueValue=255 },
        //    Edges.Round
        //    );
        //Console.WriteLine(square);

        //square.Edges = Edges.Straight;
        //Console.WriteLine(square);

        ////generic list example
        //var intlist = new GenericList<int>();
        //intlist.Add(1);
        //intlist.Add(2);
        //intlist.Add(3);
        //intlist.Add(4);
        //Console.WriteLine("Elements are: {0}",intlist.Count);
        //for (int i = 0; i < intlist.Count; i++)
        //{
        //    int element = intlist[i];
        //    Console.WriteLine(element);
        //}
        //Console.WriteLine();
        //var textList = new GenericList<string>();
        //textList.Add("One");
        //textList.Add("two");
        //textList.Add("three");
        //textList.Add("four");
        //Console.WriteLine("Elements are: {0}", textList.Count);
        //for (int i = 0; i < textList.Count; i++)
        //{
        //    string element = textList[i];
        //    Console.WriteLine(element);
        //}

        ////Generic Constraints
        //GenericConstraints<Test1> example1 = new GenericConstraints<Test1>();
        ////Inherits BaseClass and IInterfaceble and has the suitable constructor
        //// This will not compile
        ////GenericConstraintClass<TestClass2> test2 = new GenericConstraintClass<TestClass2>();
        ////Has the suitable constructor but inherits only BaseClass
        //// This will not compile
        ////GenericConstraintClass<TestClass3> test2 = new GenericConstraintClass<TestClass3>();
        ////Inherits BaseClass and IInterfaceble, but does not support no param constructor

        ////GenericMethod example
        //int i = 5;
        //int j = 7;
        //int min = GenericMethod.Min<int>(i, j);
        //Console.WriteLine("Min({0}, {1}) = {2}", i, j, min);
        //string firstString = "Rakiya";
        //string secondString = "Beer";
        //string minString = GenericMethod.Min<string>(firstString, secondString);
        //Console.WriteLine("Min({0}, {1}) = {2}", firstString, secondString, minString);
        ////Point p1 = new Point();
        ////Point p2 = new Point();
        ////Point minPoint = Min(p1, p2); // This will not compile

        ////IndexerExample
        //var bits = new Indexer();
        //bits[0] = 1;
        //bits[5] = 1;
        //bits[5] = 0;
        //bits[25] = 1;
        //bits[31] = 1;
        //for (int i = 0; i <= 31; i++)
        //{
        //    Console.WriteLine("arr[{0}] = {1}", i, bits[i]);
        //}
        //Console.WriteLine("bits = ");
        //for (int i = 0; i <= 31; i++)
        //{
        //    Console.Write(bits[i]);
        //}
        //Console.WriteLine();

        ////Operators test
        //Operators f1 = (double)1 / 4;
        //Console.WriteLine("f1 = {0}", f1);
        //Operators f2 = (double)7 / 10;
        //Console.WriteLine("f2 = {0}", f2);
        //Console.WriteLine("-f1 = {0}", -f1);
        //Console.WriteLine("f1 + f2 = {0}", f1 + f2);
        //Console.WriteLine("f1 - f2 = {0}", f1 + f2);
        //Console.WriteLine("f1 * f2 = {0}", f1 + f2);
        //Console.WriteLine("f1 / f2 = {0}", f1 / f2);
        //Console.WriteLine("f1 / f2 as double = {0}", (double)(f1 / f2));
        //Console.WriteLine("-(f1+f2)*(f1-f2/f1) = {0}", -(f1 + f2) * (f1 - f2 / f1));
        //Console.WriteLine("++f1 = {0}", ++f1);

        ////Attributes example in program go up
        //Type type = typeof(Program);
        //object[] allAttributes = type.GetCustomAttributes(false);
        //foreach (AuthorAttribute item in allAttributes)
        //{
        //    Console.WriteLine("Written by {0}",item.Name);
        //}
        //ShowMessageBox(0, "Suck me", "Whore window", 0);

    }
}

