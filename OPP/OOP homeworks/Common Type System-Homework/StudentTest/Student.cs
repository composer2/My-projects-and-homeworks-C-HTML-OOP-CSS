namespace StudentTest
{
    using System;
    using System.Text;

    public class Student : ICloneable, IComparable<Student>
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private string ssn;
        private string permanentAddress;
        private string mobilePhone;
        private string email;
        private string course;

        public Speciality Speciality { get; private set; }
        public University University { get; private set; }
        public Faculty Faculty { get; private set; }

        public Student(string firstName, string middleName, string lastName, string ssn, string permanentAddress,  string mobilePhone, string email, string course, Speciality speciality, University university, Faculty faculty)
        {
            this.firstName = firstName;
            this.middleName = middleName;
            this.lastName = lastName;
            this.course = course;
            this.mobilePhone = mobilePhone;
            this.ssn = ssn;
            this.permanentAddress = permanentAddress;
            this.email = email;
            this.Speciality = speciality;
            this.University = university;
            this.Faculty = faculty;
        }

        public string FirstName
        {
            get { return this.firstName; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("First name can't be empty");
                }
                this.firstName = value;
            }
        }
        public string MiddleName
        {
            get { return this.middleName; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Middle name can't be empty");
                }
                this.middleName = value;
            }
        }
        public string LastName
        {
            get { return this.lastName; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Last name can't be empty");
                }
                this.lastName = value;
            }
        }
        public string Course
        {
            get { return this.course; }
            private set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Course cannot be null or empty.");
                }

                this.course = value;
            }
        }

        public string SSN
        {
            get { return this.ssn; }
            private set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("SSN cannot be null or empty.");
                }

                this.ssn = value;
            }
        }
        public string PermanentAddress
        {
            get { return this.permanentAddress; }
            private set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Permanent Address cannot be null or empty.");
                }

                this.permanentAddress = value;
            }
        }
        public string MobilePhone
        {
            get { return this.mobilePhone; }
            private set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("MobilePhone cannot be null or empty.");
                }

                this.MobilePhone = value;
            }
        }
        public string Email
        {
            get { return this.email; }
            private set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Email cannot be null or empty.");
                }

                this.email = value;
            }
        }
        //override operators
        public static bool operator ==(Student student1, Student student2)
        {
            return Student.Equals(student1, student2);
        }
        public static bool operator !=(Student student1, Student student2)
        {
            return !Student.Equals(student1, student2);
        }
        //override Equals
        public override bool Equals(object obj)
        {
            var student = obj as Student;
            if (student == null || !Object.Equals(this.ssn, student.ssn))
            {
                return false;
            }
            return true;
        }
        //override to string
        public override string ToString()
        {
            var student = new StringBuilder();
            student.AppendLine("Student name: " + this.firstName + " " + this.middleName + " " + this.lastName);
            student.AppendLine(new string('*', 40));
            student.AppendLine("SSN " + this.ssn);
            student.AppendLine("Address: " + this.PermanentAddress);
            student.AppendLine("Phone: " + this.MobilePhone);
            student.AppendLine("E-mail: " + this.Email);
            student.AppendLine("Course: " + this.Course);
            student.AppendLine("Speciality: " + this.Speciality);
            student.AppendLine("University: " + this.University);
            student.AppendLine("Faculty: " + this.Faculty);

            return student.ToString();
        }

        public override int GetHashCode()
        {
            //very small chances of hash repeatence
            return firstName.GetHashCode() ^ this.middleName.GetHashCode() ^ lastName.GetHashCode();
        }

        public object Clone()
        {
            var clonedStudent = new Student(this.FirstName, this.MiddleName, this.LastName, this.SSN, this.PermanentAddress,
            this.MobilePhone, this.Email, this.Course, this.Speciality, this.University, this.Faculty);

            return clonedStudent;
        }

        public int CompareTo(Student other)
        {
            if (this.firstName!=other.firstName)
            {
                return this.firstName.CompareTo(other.firstName);
            }
            if (this.middleName != other.middleName)
            {
                return this.middleName.CompareTo(other.middleName);
            }
            if (this.lastName != other.lastName)
            {
                return this.lastName.CompareTo(other.lastName);
            }
            return this.ssn.CompareTo(other.ssn);
        }
    }
}
