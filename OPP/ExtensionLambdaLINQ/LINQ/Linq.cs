using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class Linq
    {
        private static void PrintCollection(IEnumerable collection)
        {
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
        private static void LinqKeywordsExamples()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var querySmallNums =
                from num in numbers
                where num < 5
                select num;
            foreach (var num in querySmallNums)
            {
                Console.Write(num.ToString() + " ");
            }
            Console.WriteLine();
            Console.WriteLine();

            string[] towns = { "Sofia", "Varna", "Pleven", "Ruse", "Bourgas" };

            var townPairs = from t1 in towns
                            from t2 in towns
                            select new { T1 = t1, T2 = t1 };

            foreach (var townPair in townPairs)
            {
                
                Console.WriteLine(townPair.T1+" "+townPair.T2);
            }
            Console.WriteLine();

            string[] fruits = { "cherry", "apple", "blueberry", "banana" };
            var fruitAscending = from fruit in fruits
                                 orderby fruit
                                 select fruit;
            foreach (var fruit in fruitAscending)
            {
                Console.WriteLine(fruit);
            }
            Console.WriteLine();
        }
        private static void LinqExtensionMethodsExamples()
        {
            var studentRepository = new StudentsRepository();
            var students = studentRepository.GetAllStudents();
            //where
            var someStudents = students.Where(st => st.Name == "Ivan" || st.Name == "Pesho");
            PrintCollection(someStudents);
            //first
            Student first = students.FirstOrDefault(st => st.Course.Count == 4);
            Console.WriteLine(first);
            //select
            var projectedItem = students.Select(st => new Student { Name = st.Id.ToString(), Course = new List<Course>() });
            PrintCollection(projectedItem);
            //select annonymous
            var annStudents = students.Select(st => new { Id = st.Id, Course = st.Course.Count });
            PrintCollection(annStudents);
            //order by
            var ordered = students.OrderBy(st => st.Course.Count).ThenBy(st => st.Name);
            PrintCollection(ordered);
            //any
            bool checkAny = students.Any(st => st.Name.StartsWith("I"));
            Console.WriteLine(checkAny);
            //all
            bool checkAll = students.All(st => st.Name != string.Empty);
            Console.WriteLine(checkAll);
            checkAll = students.All(st => st.Id > 2);
            Console.WriteLine(checkAll);
            //toList and toArray
            Student[] arrayOfStudents = students.ToArray();
            PrintCollection(arrayOfStudents);
            List<Student> listOfStudents = students.ToList();
            PrintCollection(listOfStudents);
            //reading string of numbers separeted by space
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            PrintCollection(numbers);
            //reverse
            students.Reverse();
            PrintCollection(students);
            //average
            double averageCourses = students.Average(st => st.Course.Count);
            Console.WriteLine(averageCourses);
            //max
            int max = students.Max(st => st.Course.Count);
            Console.WriteLine(max);
            //min
            int min = students.Min(st => st.Course.Count);
            Console.WriteLine(min);
            //count
            int count = students.Count(st => st.Name.Length > 4);
            Console.WriteLine(count);
            //sum
            int sum = students.Sum(st => st.Course.Count);
            Console.WriteLine(sum);
            //extension methods
            var someCollection = students.Where(st => st.Id > 1)
                .OrderBy(st => st.Name)
                .ThenBy(st => st.Course.Count)
                .Select(st => new { Name = st.Name, Courses = st.Course.Count })
                .ToArray();
            PrintCollection(someCollection);
            //nesting
            var someOtherStudents = students
                .Where(st => st.Course.Any(c => c.Name == "OPP"))
                .OrderBy(st => st.Name);
            PrintCollection(someOtherStudents);


        }
        static void Main(string[] args)
        {
            LinqKeywordsExamples();
            LinqExtensionMethodsExamples();
        }
    }
}
