using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndWorkers
{
    class StudentsAndWorkers
    {
        static void Main(string[] args)
        {
            //list of students

            var students = new List<Student>()
            {
                new Student("Bob", "Bobev", 1),
                new Student("Gosho", "Goshev",2),
                new Student("Pesho", "Peshev", 3),
                new Student("Tashe", "Tashev", 4),
                new Student("Kiro", "Kirov", 5),
                new Student("Georgi", "Georgiev", 6),
                new Student("Ivan", "Ivanov", 7),
                new Student("Stoqn", "Stoqnov", 8),
                new Student("Vylkan", "Vylkanov", 9),
                new Student("Boiko", "Boikov", 10)
            };
            //list of workers
            var workers = new List<Worker>()
            {
                new Worker("Marian", "Bobev", 105.7,8),
                new Worker("Stilian", "Goshev", 211.5,8),
                new Worker("Cvetan", "Peshev", 1001,12),
                new Worker("Teodor", "Tashev", 451.34,14),
                new Worker("Krasimir", "Kirov", 678.1,8),
                new Worker("Valeri", "Georgiev", 221,4),
                new Worker("Kaloyan", "Ivanov", 100,2),
                new Worker("Nikola", "Stoqnov", 1020.20,16),
                new Worker("Boris", "Vylkanov", 111.11,7),
                new Worker("Lili", "Boikova", 50,1)
            };

            //sort students by grade
            var sortedStudents = students.OrderBy(s => s.Grade);
            //sort workers hourly paid
            var sortedWorkers = workers.OrderByDescending(s => s.MoneyHourly());

            //merge list
            var mergedList = new List<Human>();
            mergedList.AddRange(sortedStudents);
            mergedList.AddRange(sortedWorkers);

            //sorted merged by first and last name
            var sortByName = mergedList.OrderBy(h => h.FirstName).ThenBy(h => h.LastName);

            Console.WriteLine("Students: ");
            Console.WriteLine(new string('*',40));
            foreach (var student in students)
            {
                Console.WriteLine(students);
            }

            Console.WriteLine("Students by grade: ");
            Console.WriteLine(new string('*', 40));
            foreach (var student in sortedStudents)
            {
                Console.WriteLine(students);
            }

            Console.WriteLine("Workers: ");
            Console.WriteLine(new string('*', 40));
            foreach (var worker in workers)
            {
                Console.WriteLine(worker);
            }

            Console.WriteLine("Workers by salary: ");
            Console.WriteLine(new string('*', 40));
            foreach (var worker in sortedWorkers)
            {
                Console.WriteLine(worker);
            }

            Console.WriteLine("Merged list: ");
            Console.WriteLine(new string('*', 40));
            foreach (var human in mergedList)
            {
                Console.WriteLine(human);
            }

            Console.WriteLine("Merged list sorted by name: ");
            Console.WriteLine(new string('*', 40));
            foreach (var human in sortByName)
            {
                Console.WriteLine(human);
            }
        }
    }
}
