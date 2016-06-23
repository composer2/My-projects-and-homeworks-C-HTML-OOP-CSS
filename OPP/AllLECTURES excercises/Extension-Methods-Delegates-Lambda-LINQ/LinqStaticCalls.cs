using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_Methods_Delegates_Lambda_LINQ
{
    internal class LinqStaticCalls
    {
        public static void LinqKeywordsExamples()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var smallNum = from n in numbers
                           where n < 5
                           select n;
            foreach (var item in smallNum)
            {
                Console.Write(item.ToString() + " ");
            }
            Console.WriteLine();
            string[] towns = { "Sofia", "Varna", "Pleven", "Ruse", "Bourgas" };
            var pairs = from t1 in towns
                        from t2 in towns
                        select new { T1 = t1, T2 = t2 };
            foreach (var item in pairs)
            {
                Console.Write(item.ToString() + " ");
            }
            Console.WriteLine();
            string[] fruits = { "cherry", "apple", "blueberry", "banana" };
            var sortedFruits = from f in fruits
                               orderby f
                               select f;
            foreach (var item in sortedFruits)
            {
                Console.Write(item.ToString() + " ");
            }
            Console.WriteLine();
        }
        public static void LinqExtensionMethodsExamples()
        {
            var studentsRepo = new StudentsRepository();
            var students = studentsRepo.GetAllStudents();
            //where
            var someStudents = students.Where(st => st.Name == "Ivan" || st.Name == "Pesho");
            PrintCollection(someStudents);
            //first
            Student first = students.FirstOrDefault(st => st.Courses.Count == 2);
            Console.WriteLine(first);
            //select
            var projectedItems = students.Select(st => new Student { Name = st.Id.ToString(), Courses = new List<Course>() });
            PrintCollection(projectedItems);
            //select to anonymous
            var annStudent = students.Select(st => new { Id = st.Id, Course = st.Courses.Count });
            PrintCollection(annStudent);
            //order by
            var ordered = students.OrderBy(st => st.Courses.Count).ThenBy(st => st.Name);
            PrintCollection(ordered);
            //any
            bool checkAny = students.Any(st => st.Name.StartsWith("P"));
            Console.WriteLine(checkAny);
            //all
            bool checkAll = students.All(st => st.Name != string.Empty);
            Console.WriteLine(checkAll);
            checkAll = students.All(st => st.Id > 2);
            Console.WriteLine(checkAll);
            //to list to array
            Student[] arrayOfStudents = students.ToArray();
            PrintCollection(arrayOfStudents);
            List<Student> listOfStudents = arrayOfStudents.ToList();
            PrintCollection(listOfStudents);
            // reading string of numbers separated by space
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            PrintCollection(numbers);
            //reverse
            students.Reverse();
            PrintCollection(students);
            //average
            double averageCourses = students.Average(st => st.Courses.Count);
            Console.WriteLine(averageCourses);
            //max
            int max = students.Max(st => st.Courses.Count);
            Console.WriteLine(max);
            //min
            int min = students.Min(st => st.Courses.Count);
            Console.WriteLine(min);
            //count
            int count = students.Count(st => st.Name.Length > 4);
            Console.WriteLine(count);
            //sum
            int sum = students.Sum(st => st.Courses.Count);
            Console.WriteLine(sum);
            // extension methods
            var someCollection = students.Where(st => st.Id > 1)
                .OrderBy(st => st.Name)
                .ThenBy(st => st.Courses.Count)
                .Select(st => new { Name = st.Name, Course = st.Courses.Count })
                .ToArray();
            PrintCollection(someCollection);

            //nesting
            var someOtherStudents = students.Where(st => st.Courses.Any(c => c.Name == "OOP"))
                .OrderBy(st => st.Name);
            PrintCollection(someOtherStudents);
        }
        private static void PrintCollection(IEnumerable collection)
        {
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
