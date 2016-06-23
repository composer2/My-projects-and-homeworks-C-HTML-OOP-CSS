using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AllClassesAndStruct;

namespace FirstBeforeLast
{
    public class FirstBeforeLast
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

            Console.WriteLine("The list of students: ");
            Console.WriteLine(new string('*',40));
            foreach (var student in students)
            {
                Console.WriteLine(student.FirstName+" "+student.LastName);
            }

            var selectedStudents = SortStudentsByName(students);
            Console.WriteLine();
            Console.WriteLine("List of students whose first name is before their last name: ");
            Console.WriteLine(new string('*', 40));
            foreach (var student in selectedStudents)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }
        }
        private static IEnumerable<Student> SortStudentsByName(Student[] students)
        {
            var selectedStudents =
            from student in students
            where student.FirstName.CompareTo(student.LastName) < 0
            select student;

            return selectedStudents;
        }
    }
}
