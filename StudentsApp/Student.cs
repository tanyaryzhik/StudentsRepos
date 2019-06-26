using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsApp
{
    public class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Faculty { get; set; }

        public int Course { get; set; }

        public int Group { get; set; }

        public string StudentData { get; set; }

        public Student(string firstName, string lastName, string faculty, int course, int group)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Faculty = faculty;
            this.Course = course;
            this.Group = group;
            StudentData = String.Format("{0,15} {1,15} {2,15} {3,15} {4,15}", firstName, lastName, faculty, course, group);
        }
    }
}
