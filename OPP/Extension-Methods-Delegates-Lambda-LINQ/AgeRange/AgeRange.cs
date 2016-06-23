using AllClassesAndStruct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeRange
{
    class AgeRange
    {
        static void Main(string[] args)
        {
            var students = new Student[]
            {
                new Student("Bob", "Dilyn",26),
                new Student("Dylan", "Harper",34),
                new Student("Arianna", "Grande",21),
                new Student("John", "Smith",18),
                new Student("Zoe", "Rapeson",19),
                new Student("Bob", "Chuskin",27),
                new Student("Nasakota", "Yakata",23)
            };

            var sortedStudents =
                from student in students
                where student.Age >= 18 && student.Age <= 24
                select student;

            Console.WriteLine("List of students: ");
            Console.WriteLine(new string('*', 40));
            foreach (var student in students)
            {
                Console.WriteLine("{0} {1} {2}", student.FirstName, student.LastName, student.Age);
            }

            Console.WriteLine();
            Console.WriteLine("List of students with ages between 18 and 24: ");
            Console.WriteLine(new string('*', 40));
            foreach (var student in sortedStudents)
            {
                Console.WriteLine("{0} {1} {2}", student.FirstName, student.LastName, student.Age);
            }
        }
    }
}
