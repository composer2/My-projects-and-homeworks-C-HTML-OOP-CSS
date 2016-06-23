using System;
namespace SofiaUniversity.Data
{
    public struct Faculty
    {
        public string Name { get; set; }
    }
    public class Professor
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Faculty Faculty { get; set; }
        public string Subject { get; set; }
    }
    public enum Speciality
    {
        ComputerScience,
        SoftwareEngineering,
        InformationSystem
    }
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Faculty Faculty { get; set; }
        public Speciality Speciality { get; set; }
        public int FacultyNumber { get; set; }

    }
}
namespace SofiaUniversity.UI
{
    public class ProfessorAdminForm : System.Windows.Forms.Form
    {
        //...
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // ProfessorAdminForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Name = "ProfessorAdminForm";
            this.Text = "Professors";
            this.ResumeLayout(false);
        }
    }
    public class StudentAdminForm : System.Windows.Forms.Form
    {
        // ...
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // StudentAdminForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Name = "StudentAdminForm";
            this.Text = "Students";
            this.ResumeLayout(false);

        }
    }
}
namespace SofiaUniversity
{
    public class AdministrationSystem
    {
        static void Main()
        {
            // ...
        }
    }
}


