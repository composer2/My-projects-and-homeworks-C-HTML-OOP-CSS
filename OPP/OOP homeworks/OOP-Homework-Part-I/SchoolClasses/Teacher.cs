using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses
{
    public class Teacher :Person
    {
        public List<Discipline> Disciplines { get; private set; }

        public Teacher(string firstName, string lastName)

            : base(firstName, lastName)
        {
            this.Disciplines = new List<Discipline>();
        }

        new public string FirstName
        {
            get
            {
                return base.FirstName;
            }
        }

        new public string LastName
        {
            get
            {
                return base.LastName;
            }
        }

        public void AddDiscipline(Discipline discipline)
        {
            this.Disciplines.Add(discipline);
        }

        public void RemoveDiscipline(Discipline discipline)
        {
            if (!this.Disciplines.Contains(discipline))
            {
                throw new ArgumentException("No such discipline.");
            }
            this.Disciplines.Remove(discipline);
        }

        public void AddDisciplines(params Discipline[] disciplines)
        {
            this.Disciplines.AddRange(disciplines);
        }

        public void ClearDisciplines()
        {
            this.Disciplines.Clear();
        }

        public override string ToString()
        {
            var teacher = new StringBuilder();

            var counter = 1;
            foreach (var discipline in Disciplines)
            {
                teacher.AppendLine(discipline.ToString());
                counter++;
            }
            return base.ToString()+teacher; 
        }
    }
}
