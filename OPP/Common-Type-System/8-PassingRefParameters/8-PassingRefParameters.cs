using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_PassingRefParameters
{
    public struct Point
    {
        internal int x;
        internal int y;
    }
    public class MultiplyPoint
    {
        public static void IncorectMultiply(Point point)
        {
            point.x *= 2;
            point.y *= 2;
        }
        public static void MultiplyBy2(ref Point point)
        {
            point.x *= 2;
            point.y *= 2;
        }
    }
    public class Student
    {
        public string name;

        public Student(string name)
        {
            this.name = name;
        }

        public static void IncorrectModifyStudent(Student student)
        {
            student = new Student("Changed: " + student.name);
        }

        public static void ModifyStudent(ref Student student)
        {
            student = new Student("Changed: " + student.name);
        }
    }
    public class PassingRefParameters
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test passing class (reference type) by reference:");
            var s = new Student("Telerik Academy");
            Console.WriteLine(s.name);
            Student.IncorrectModifyStudent(s);
            Console.WriteLine(s.name);
            Student.ModifyStudent(ref s);
            Console.WriteLine(s.name);
            Console.WriteLine();
            Console.WriteLine("Test passing struct (value type) by reference:");
            Point p = new Point() { x = 5, y = -8 };
            Console.WriteLine(p.x + " " + p.y);
            MultiplyPoint.IncorectMultiply(p);
            Console.WriteLine(p.x + " " + p.y);
            MultiplyPoint.MultiplyBy2(ref p);
            Console.WriteLine(p.x + " " + p.y);
        }
    }
}
