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

        private string headerOfTable;

        public ManagerOfStudentsList()
        {
            this.StudentsList = new List<Student>();
            this.headerOfTable = String.Format("{0,15} {1,15} {2,15} {3,15} {4,15}", "First Name", "Last Name", "Faculty", "Course", "Group");
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
            Console.WriteLine(headerOfTable);
            foreach (var student in StudentsList)
            {
                Console.WriteLine(student.StudentData);
            }
        }

        public Student GetStudent(string firstName, string lastName)
        {
            Dictionary<string, Student> studentsDictionary = InitializeDictionary();
            studentsDictionary.TryGetValue(firstName + lastName, out Student student);
            return student;
        }

        private Dictionary<string, Student> InitializeDictionary()
        {
            Dictionary<string, Student> dictionary = new Dictionary<string, Student>();
            foreach (var student in this.StudentsList)
            {
                dictionary.Add(student.FirstName + student.LastName, student);
            }
            return dictionary;
        }
    }
}
