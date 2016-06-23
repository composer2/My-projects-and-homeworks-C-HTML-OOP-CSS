using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_Methods_Delegates_Lambda_LINQ
{
    internal class StudentsRepository
    {
        public IEnumerable<Student> GetAllStudents()
        {
            var oop = new Course { Id = 1, Name = "OOP" };
            var Csharp = new Course { Id = 2, Name = "Csharp" };
            var java = new Course { Id = 3, Name = "Java" };

            var students = new List<Student>
            {
                new Student
                {
                    Id = 1,
                    Name = "Ivan",
                    Courses = new List<Course> { oop, java }
                },
                new Student
                {
                    Id = 2,
                    Name = "Pesho",
                    Courses = new List<Course> { oop, java,Csharp }
                },new Student
                {
                    Id = 3,
                    Name = "Gosho",
                    Courses = new List<Course> { Csharp, java}
                }
            };
            return students;
        }
    }
}
