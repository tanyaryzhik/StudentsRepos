using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsApp
{
    public class ManagerOfStudentsList
    {
        public List<Student> StudentsList { get; set; }

        public StringBuilder Header { get; set; }

        public ManagerOfStudentsList()
        {
            this.StudentsList = new List<Student>();
        }

        public void Add(Student student)
        {
            if (student is null)
                throw new ArgumentNullException();
            this.StudentsList.Add(student);
        }

        public void Remove(Student student)
        {
            if (student is null)
                throw new ArgumentNullException();
            if (!this.StudentsList.Contains(student))
                throw new ArgumentException();
            this.StudentsList.Remove(student);
        }

        public void DisplayStudentsList()
        {
            Console.WriteLine($"There're {StudentsList.Count} students.");
            Header = new StringBuilder(String.Format("{0,15} {1,15} {2,15} {3,15} {4,15}", "First Name", "Last Name", "Faculty", "Course", "Group"));
            Console.WriteLine(Header);
            foreach (var student in StudentsList)
            {
                Console.WriteLine(student.StudentData);
            }
        }
    }
}
