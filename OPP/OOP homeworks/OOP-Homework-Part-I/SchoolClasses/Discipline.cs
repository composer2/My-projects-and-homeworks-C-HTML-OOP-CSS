using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses
{
    public class Discipline : IComment
    {
        private string name;
        private int numberOfExcercises;
        private int numberOfLectures;
        public List<string> Comments { get; set; }

        public Discipline(string name, int numberOfExcercises, int numberOfLectures)
        {
            this.name = name;
            this.numberOfExcercises = numberOfExcercises;
            this.numberOfLectures = numberOfLectures;
            this.Comments = new List<string>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Discipline cannont be null or empty");
                }
                this.name = value;
            }
        }
        public int NumberOfExcercises
        {
            get
            {
                return this.numberOfExcercises;
            }
            private set
            {
                if (value<1)
                {
                    throw new ArgumentException("Excercises must one or more");
                }
                this.numberOfExcercises = value;
            }
        }

        public int NumberOfLectures
        {
            get
            {
                return this.numberOfLectures;
            }
            private set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Lectures must one or more");
                }
                this.numberOfLectures = value;
            }
        }

        public void AddComment(string comment)
        {
            this.Comments.Add(comment);
        }

        public void RemoveComment(string comment)
        {
            if (!this.Comments.Contains(comment))
            {
                throw new ArgumentException("There is no such comment");
            }
            this.Comments.Remove(comment);
        }

        public override string ToString()
        {
            var discipline = new StringBuilder();
            discipline.AppendLine("Discipline: " + this.name);
            discipline.AppendLine("Number of exercises: " + this.numberOfExcercises);
            discipline.AppendLine("Number of lectures: " + this.numberOfLectures);

            var counter = 1;
            foreach (var comment in this.Comments)
            {
                discipline.AppendFormat("Comment {0} : {1}", counter, comment);
                discipline.AppendLine();
                counter++;
            }
            return discipline.ToString();
        }
    }
}
