using AllClassesAndStruct;
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
            //lists of students and groups
            var students = new List<Student>()
            {
                new Student("Bob", "Dilyn","238406", "029623625", "bob@abv.bg",1),
                new Student("Dylan", "Harper","343252", "033421125", "dylan@gmail.bg",2),
                new Student("Arianna", "Grande","345406", "7803625", "ariana@abv.bg",3),
                new Student("John", "Smith","212306", "1233625", "jon@yahoo.com",4),
                new Student("Zoe", "Rapeson","231113", "02222229623625", "zoe@abv.bg",2),
                new Student("Bob", "Chuskin","277706", "02255555553625", "bob1@abv.bg",1),
                new Student("Nasakota", "Yakata","234563", "022987654325", "zoe@gmail.com",4)
            };

            var studentsWithGroups = new List<Student>()
            {
                new Student("Bob", "Dilyn","238403", "029623625", "bob@abv.bg",new Group(2,"Yoga")),
                new Student("Dylan", "Harper","342506", "033421125", "dylan@gmail.bg",new Group(3,"Fitness")),
                new Student("Arianna", "Grande","345672", "7803625", "ariana@abv.bg",new Group(1,"Judo")),
                new Student("John", "Smith","212406", "1233625", "jon@yahoo.com",new Group(4,"Box")),
                new Student("Zoe", "Rapeson","211306", "04222229623625", "zoe@abv.bg",new Group(1,"Judo")),
                new Student("Bob", "Chuskin","275777", "02255555553625", "bob1@abv.bg",new Group(2,"Yoga")),
                new Student("Nasakota", "Yakata","434563", "022987654325", "zoe@gmail.com",new Group(3,"Fitness"))
            };

            var groups = new List<Group>()
            {
               new Group(1, "Judo"),
                new Group(2, "Yoga"),
                new Group(3, "Fitness"),
                new Group(4, "Box")
            };

            //adding marks
            students[0].AddMarks(new int[] { 2, 3, 5, 6 });
            students[1].AddMarks(new int[] { 2, 2, 5, 4 });
            students[2].AddMarks(new int[] { 3, 3, 6, 6 });
            students[3].AddMarks(new int[] { 2, 3, 5, 2 });
            students[4].AddMarks(new int[] { 4, 4, 5 });
            students[5].AddMarks(new int[] { 2, 3 });
            students[6].AddMarks(new int[] { 2, 3, 5, 2 });


            //Problem 9. Create a List<Student> with sample students. Select only the students that are from group number 2.
            //Use LINQ query. Order the students by FirstName.
            var secondGroupStudents = from student in students
                                      where student.GroupNumber == 2
                                      orderby student.FirstName
                                      select student;

            Console.WriteLine("Students from second group(LINQ): ");
            Console.WriteLine(new string('*', 40));
            foreach (var student in secondGroupStudents)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }

            //Problem 10. Student groups extensions
            //Implement the previous using the same query expressed with extension methods.
            var newSecondGroupStudents = students.Where(st => st.GroupNumber == 2).OrderBy(st => st.FirstName);

            Console.WriteLine();
            Console.WriteLine("Students from second group(Lambda): ");
            Console.WriteLine(new string('*', 40));
            foreach (var student in newSecondGroupStudents)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }

            // Problem 11.Extract students by email
            //Extract all students that have email in abv.bg.
            //Use string methods and LINQ.
            var studentWithEmailABV = from student in students
                                      where student.Email.Substring(student.Email.IndexOf("@") + 1) == "abv.bg"
                                      select student;
            Console.WriteLine();
            Console.WriteLine("Students with an email in abv.bg: ");
            Console.WriteLine(new string('*', 40));
            foreach (var student in studentWithEmailABV)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }
            //Problem 12. Extract students by phone
            //Extract all students with phones in Sofia.
            //Use LINQ.
            var studentsWithSofiaPhone = from student in students
                                         where student.Phone.StartsWith("02")
                                         select student;

            Console.WriteLine();
            Console.WriteLine("Students with a Sofia phone number: ");
            Console.WriteLine(new string('*', 40));
            foreach (var student in studentsWithSofiaPhone)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }

            //Problem 13. Extract students by marks
            //Select all students that have at least one mark Excellent (6) into a new anonymous class that has properties – FullName and Marks.
            //Use LINQ.

            var exelentStudentsMarks = from student in students
                                       where student.Marks.Contains(6)
                                       select new { fullName = student.FirstName + " " + student.LastName, marks = string.Join(", ", student.Marks) };
            Console.WriteLine();
            Console.WriteLine("Students with at least one 6 grade: ");
            Console.WriteLine(new string('*', 40));
            foreach (var student in exelentStudentsMarks)
            {
                Console.WriteLine(student.fullName + " " + student.marks);
            }

            //Problem 14. Extract students with two marks
            //Write down a similar program that extracts the students with exactly two marks "2".
            //Use extension methods.

            var studentsWithTwoGrades = students.Where(s => s.Marks.Count(x => Math.Abs(x - 2) < 0.4) == 2)
                                              .Select(s => s.FirstName + " " + s.LastName + " " + String.Join(", ", s.Marks));
            Console.WriteLine();
            Console.WriteLine("Students with exatly two marks \"2\": ");
            Console.WriteLine(new string('*', 40));
            foreach (var student in studentsWithTwoGrades)
            {
                Console.WriteLine(student);
            }

            //Problem 15. Extract marks
            //Extract all Marks of the students that enrolled in 2006. (The students from 2006 have 06 as their 5-th and 6-th digit in the FN).
            var studentsFrom2006 = students.Where(s => s.FacultyNumber[4] == '0' && s.FacultyNumber[5] == '6');

            Console.WriteLine();
            Console.WriteLine("Students that enrolled in 2006: ");
            Console.WriteLine(new string('*', 40));
            foreach (var student in studentsFrom2006)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }

            //Problem 16.* Groups
            //Create a class Group with properties GroupNumber and DepartmentName.
            //Introduce a property GroupNumber in the Student class.
            //Extract all students from "Fitness" department.
            //Use the Join operator.
            var fittStudents = from student in students
                               join grp in groups on student.GroupNumber equals grp.GroupNumber
                               where grp.DepartmentName == "Fitness"
                               select student;

            Console.WriteLine();
            Console.WriteLine("Students in Fitness Group: ");
            Console.WriteLine(new string('*', 40));
            foreach (var student in fittStudents)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }


            //Problem 18. Grouped by GroupNumber
            //Create a program that extracts all students grouped by GroupNumber and then prints them to the console.
            //Use LINQ.
            var groupedStudentsLINQ = from student in studentsWithGroups
                                      orderby student.Group.GroupNumber
                                      select student;

            Console.WriteLine();
            Console.WriteLine("Students ordered by Groups(LINQ): ");
            Console.WriteLine(new string('*', 40));
            foreach (var student in groupedStudentsLINQ)
            {
                Console.WriteLine("{0}. {1}: {2} {3}",student.Group.GroupNumber,student.Group.DepartmentName,student.FirstName,student.LastName);
            }

            //Problem 19. Grouped by GroupName extensions
            //Rewrite the previous using extension methods.

            var groupedStudentsExtension = studentsWithGroups.OrderBy(s => s.Group.GroupNumber);
            Console.WriteLine();
            Console.WriteLine("Students ordered by Groups(extention methods): ");
            Console.WriteLine(new string('*', 40));
            foreach (var student in groupedStudentsExtension)
            {
                Console.WriteLine("{0}. {1}: {2} {3}", student.Group.GroupNumber, student.Group.DepartmentName, student.FirstName, student.LastName);
            }
        }
    }
}
