using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses
{
    public class Class : IComment
    {
        public string TextID { get; private set; }
        public List<Teacher> AllTeachers { get; private set; }
        public List<string> Comments { get; private set; }
        
        public Class(string textID, params Teacher[] allTeachers)
        {
            this.TextID = textID;
            this.AllTeachers = new List<Teacher>();
            this.AllTeachers.AddRange(allTeachers);
        }

        public void AddComment(string comment)
        {
            this.Comments.Add(comment);
        }

        public void RemoveComment(string comment)
        {
            if (!this.Comments.Contains(comment))
            {
                throw new ArgumentException("No such comment exist");
            }
            this.Comments.Remove(comment);
        }

        public override string ToString()
        {
            var classes = new StringBuilder();
            classes.AppendLine("Classes: " + this.TextID);

            var counter = 1;
            foreach (var teacher in AllTeachers)
            {
                classes.AppendFormat("Teacher {0}: {1} {2}", counter, teacher.FirstName, teacher.LastName);
            }

            return classes.ToString();
        }
    }
}
