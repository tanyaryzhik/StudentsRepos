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

        public Queue<string> TasksList;

        public Student(string firstName, string lastName, string faculty, int course, int group)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Faculty = faculty;
            this.Course = course;
            this.Group = group;
            this.TasksList = new Queue<string>();
            StudentData = String.Format("{0,15} {1,15} {2,15} {3,15} {4,15}", firstName, lastName, faculty, course, group);
        }

        public void GetTasksList()
        {
            Console.WriteLine("Enter tasks. When list is full press spacebar");
            bool IsListFinshed = false;
            string task = string.Empty;
            while(!IsListFinshed)
            {
                task = Console.ReadLine();
                if (task == " ")
                {
                    IsListFinshed = true;
                    continue;
                }
                TasksList.Enqueue(task);
            }
        }

        public void CompleteTasks(Queue<string> list)
        {
            int listLength = list.Count;
            for (int i = 0; i < listLength; i++)
            {
                Console.WriteLine($"{list.Dequeue()} - Done");
            }
        }
    }
}
