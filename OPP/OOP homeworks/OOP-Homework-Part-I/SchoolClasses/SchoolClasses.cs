using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses
{
    class SchoolClasses
    {
        static void Main(string[] args)
        {
            //list of students
            var students = new List<Student>()
            {
                new Student("Bob","Bobev",111111,21,"male"),
                new Student("Bob","Bobev",222222,19,"female"),
                new Student("Bob","Bobev",333333)
            };
            //list of techers
            var teachers = new List<Teacher>()
            {
                 new Teacher("Ivan", "Kostov"),
                 new Teacher("Tashe", "Tashev"),
                 new Teacher("Koceto", "Jani"),
            };

            //add disciplines
            teachers[0].AddDiscipline(new Discipline("Photoshop",3,6));
            teachers[0].AddDiscipline(new Discipline("Coreal Draw",13,16));
            teachers[1].AddDiscipline(new Discipline("Git source control",8,16));
            teachers[1].AddDiscipline(new Discipline("C#",5,9));
            teachers[2].AddDiscipline(new Discipline("JavaScript",10,20));

            //creating school with a class and adding teachers
            var school = new School();
            school.AddClass(new Class("Ultimate", teachers[0], teachers[1], teachers[2]));

            Console.WriteLine("Students: ");
            Console.WriteLine(new string('*',40));

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("Teachers: ");
            Console.WriteLine(new string('*', 40));

            foreach (var teacher in teachers)
            {
                Console.WriteLine(teacher);
            }

            Console.WriteLine("School: ");
            Console.WriteLine(new string('*', 40));
            Console.WriteLine(school);
        }
    }
}
