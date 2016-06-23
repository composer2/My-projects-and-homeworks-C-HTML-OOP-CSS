using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class StudentsRepository
    {
        public IEnumerable<Student> GetAllStudents()
        {
            var oop = new Course { Id = 1, Name = "OOP" };
            var csharp = new Course { Id = 2, Name = "CSharp" };
            var js = new Course { Id = 3, Name = "JavaScript" };

            var students = new List<Student>
            {
                new Student
                {
                    Id=1,
                    Name="Ivan",
                    Course=new List<Course> {oop, csharp }
                },
                new Student
                {
                    Id=2,
                    Name="Gosho",
                    Course=new List<Course> {oop, js, csharp }
                },new Student
                {
                    Id=3,
                    Name="Pesho",
                    Course=new List<Course> {js, csharp }
                }
            };
            return students;
        }
    }
}
