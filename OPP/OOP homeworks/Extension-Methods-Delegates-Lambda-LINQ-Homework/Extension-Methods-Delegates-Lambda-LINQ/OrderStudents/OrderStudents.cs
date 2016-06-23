using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AllClassesAndStruct;

namespace OrderStudents
{
    class OrderStudents
    {
        static void Main(string[] args)
        {
            var students = new Student[]
            {
                new Student("Bob", "Dilyn"),
                new Student("Dylan", "Harper"),
                new Student("Arianna", "Grande"),
                new Student("John", "Smith"),
                new Student("Zoe", "Rapeson"),
                new Student("Bob", "Chuskin"),
                new Student("Nasakota", "Yakata")
            };

            //sorting with OrderBy() and ThenBy()
            var lambdaSort = students.OrderByDescending(s => s.FirstName).ThenByDescending(s => s.LastName);
            Console.WriteLine("Students sorted with lambda expressions: ");
            Console.WriteLine(new string('*', 40));
            foreach (var student in lambdaSort)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }

            //sorting with LINQ

            var linqSort = from student in students
                           orderby student.FirstName descending, student.LastName descending
                           select student;

            Console.WriteLine();
            Console.WriteLine("Students sorted with LINQ: ");
            Console.WriteLine(new string('*', 40));
            foreach (var student in linqSort)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }
        }
    }
}
