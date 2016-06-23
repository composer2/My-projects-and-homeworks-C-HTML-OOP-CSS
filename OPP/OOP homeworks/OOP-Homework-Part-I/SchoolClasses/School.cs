using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses
{
    public class School
    {
        public List<Class> Classes { get; private set; }

        public School()
        {
            this.Classes = new List<Class>();
        }

        public void AddClass(Class newClass)
        {
            this.Classes.Add(newClass);
        }

        public void RemoveClass(Class existingClass)
        {
            if (!this.Classes.Contains(existingClass))
            {
                throw new ArgumentException("No such class");
            }
            this.Classes.Remove(existingClass);
        }

        public void AddClasses(params Class[] classes)
        {
            this.Classes.AddRange(classes);
        }

        public override string ToString()
        {
            var school = new StringBuilder();

            var counter = 1;
            foreach (var newClass in Classes)
            {
                school.AppendFormat("Class {0} : {1}", counter,newClass.TextID);
                school.AppendLine();
                school.AppendLine("Teachers:");

                foreach (var teacher in newClass.AllTeachers)
                {
                    school.AppendLine(teacher.FirstName +" "+teacher.LastName);
                }
            }
            return school.ToString();
        }
    }
}
