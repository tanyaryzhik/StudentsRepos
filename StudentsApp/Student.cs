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

        public Queue<string> TasksList { get; set; }

        public Stack<string> BooksList { get; set; }

        public Student(string firstName, string lastName, string faculty, int course, int group)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Faculty = faculty;
            this.Course = course;
            this.Group = group;
            this.TasksList = new Queue<string>();
            this.BooksList = new Stack<string>();
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

        public void GetBooks()
        {
            Console.WriteLine("What books do you want to take? When list is full press spacebar");
            bool IsListFinshed = false;
            string book = string.Empty;
            while (!IsListFinshed)
            {
                book = Console.ReadLine();
                if (book == " ")
                {
                    IsListFinshed = true;
                    continue;
                }
                BooksList.Push(book);
                Console.WriteLine($"{book} is recieved");
            }
        }

        public void ReturnBooks(Stack<string> booksList)
        {
            int listLength = booksList.Count;
            for (int i = 0; i < listLength; i++)
            {
                Console.WriteLine($"{booksList.Pop()} is given back");
            }
        }
    }
}
