using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AllClassesAndStruct
{
    public class Student
    {
        private string firstName;
        private string lastName;
        private int age;
        private string facultyNumber;
        private string phone;
        private string email;
        private List<int> marks;
        private int groupNumber;
        private Group group;

        //constructor
        public Student(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.marks = new List<int>();
        }

        public Student(string firstName, string lastName, int age)
            : this(firstName, lastName)
        {
            this.age = age;
        }

        public Student(string firstName, string lastName, string facultyNumber, string phone, string email, int groupNumber)
            : this(firstName, lastName)
        {
            this.facultyNumber = facultyNumber;
            this.phone = phone;
            this.email = email;
            this.groupNumber = groupNumber;
        }

        public Student(string firstName, string lastName, string facultyNumber, string phone, string email, Group group)
            : this(firstName, lastName)
        {
            this.facultyNumber = facultyNumber;
            this.phone = phone;
            this.email = email;
            this.group = group;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Enter your first name!!!");
                }
                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Last name cannot be an empty string");
                }

                this.lastName = value;
            }
        }
        public string FacultyNumber
        {
            get
            {
                return this.facultyNumber;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Faculty number cannot be empty.");
                }

                this.facultyNumber = value;
            }

        }

        public string Phone
        {
            get
            {
                return this.phone;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Phone number cannot be empty.");
                }

                this.phone = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Email cannot be an empty string.");
                }
                if (!Regex.IsMatch(value, @"(\w+@\w+.\w+)"))
                {
                    throw new ApplicationException("Email must be valid.");
                }
                this.email = value;
            }
        }

        public int GroupNumber
        {
            get
            {
                return this.groupNumber;
            }
            set
            {
                if (value<1)
                {
                    throw new ArgumentException("Group number must be larger than zero.");
                }
                this.groupNumber = value;
            }
        }
        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age must be larger than zero.");
                }
                this.age = value;
            }
        }

        public List<int> Marks
        {
            get
            {
                return this.marks;
            }
            set
            {
                this.marks = value;
            }
        }
        public Group Group
        {
            get
            {
                return this.group;
            }
            set
            {
                this.group = value;
            }
        }

        //methods

        public void AddMark(int mark)
        {
            if (mark<2||mark>6)
            {
                throw new ArgumentException("Marks must have a value between 2 and 6.");
            }
            this.Marks.Add(mark);
        }

        public void RemoveMark(int mark)
        {
            if (!this.Marks.Contains(mark))
            {
                throw new ArgumentException("Student doesn't have such mark.");
            }
            this.Marks.Remove(mark);
        }
        public void AddMarks(params int[] marks)
        {
            foreach (var mark in marks)
            {
                if (mark < 2 || mark > 6)
                {
                    throw new ArgumentException("Marks must have a value between 2 and 6.");
                }
                this.Marks.Add(mark);
            }
        }

        public override string ToString()
        {
            return String.Format("{0} {1}", this.firstName, this.lastName);
        }
    }
}

