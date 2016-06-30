using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_SystemObject_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Student first = new Student();
            first.Name = "Bachi Kiko";
            first.Age = 22;
            Console.WriteLine(first);

            Student secondStudent = new Student();
            if (first != secondStudent)  // it is true
                Console.WriteLine("{0} != {1}", first, secondStudent);

            secondStudent.Name = "Bachi Kiko";
            secondStudent.Age = 22;
            if (first == secondStudent)  // it is true
                Console.WriteLine("{0} == {1}", first, secondStudent);
        }
    }
}
