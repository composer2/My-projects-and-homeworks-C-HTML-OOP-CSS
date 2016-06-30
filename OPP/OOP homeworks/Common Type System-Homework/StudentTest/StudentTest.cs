using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTest
{
    class StudentTest
    {
        static void Main(string[] args)
        {
            //list of students
            var students = new List<Student>()
            {
                new Student("Boncho","Borislavov","Belutov","1234567890","24 Kaloyan str. Sofia","0987654321","something@abv.bg","SemesterOne",Speciality.ITengeneering,University.NBU,Faculty.IT),
                new Student("Asen","Borisov","Dimitrov","0987632","124 Zaichar str. Sofia","1234567890","else@abv.bg","SemesterTwo",Speciality.Economics,University.SofiaUniversity,Faculty.Finance),
                new Student("Tedi","Yoradnova","Koleva","2345657","13 Germna str. Sofia","5647389","Idelse@abv.bg","SemesterFour",Speciality.DigitalSales,University.MTMcollege,Faculty.Marketing),
                new Student("Roni","Tosheva","Ivanova","08791875","1 Tzar Simeno II str. Sofia","629230574","opa@abv.bg","SemesterEight",Speciality.Physics,University.MU,Faculty.Physics)
            };

            //cloning first student
            var cloning = (Student)students[0].Clone();
            Console.WriteLine("Cloned Student 1: ");
            Console.WriteLine(new string('*', 40));
            Console.WriteLine(cloning.ToString());
            //compare the cloned with CompareTo and ==
            var cloningOpeator = cloning == students[0];
            Console.WriteLine("Comparing cloned student to base student using == operator: ");
            Console.WriteLine(new string('*', 40));
            Console.WriteLine("Does cloned Student == base Student? {0}", cloningOpeator ? "Yes." : "No.");
            Console.WriteLine();

            var clonedCompareTo = cloning.CompareTo(students[0]);
            Console.WriteLine("Comparing cloned student to base student using CompareTo(): ");
            Console.WriteLine(new string('*', 40));
            Console.WriteLine("Does cloned Student == base Student? {0}", clonedCompareTo == 0 ? "Yes." : "No.");
            Console.WriteLine();

            //compare some students with CompareTo and ==
            var compareSomeStudents = students[1] == students[2];
            Console.WriteLine("Comparing  Student 1 to Student 2 using == operator: ");
            Console.WriteLine(new string('*', 40));
            Console.WriteLine("Does Student 1 == Student 2? {0}", compareSomeStudents ? "Yes." : "No.");
            Console.WriteLine();

            var studentsCompareTo = students[1].CompareTo(students[2]);
            Console.WriteLine("Comparing Student 1 to Student 2 using CompareTo(): ");
            Console.WriteLine(new string('*', 40));
            Console.WriteLine("Does  Student 1 ==  Student 2 ? {0}", studentsCompareTo == 0 ? "Yes." : "No.");
            Console.WriteLine();

            //print the collection
            foreach (var item in students)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
