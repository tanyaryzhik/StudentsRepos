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
            this.StudentData = String.Format("{0,15} {1,15} {2,15} {3,15} {4,15}", firstName, lastName, faculty, course, group);
        }

        public void GetTasksList()
        {
            Console.WriteLine("Enter tasks. When list is full press spacebar");
            bool isListFinshed = false;
            string task = string.Empty;
            while(!isListFinshed)
            {
                task = Console.ReadLine();

                if (task == " ")
                {
                    isListFinshed = true;
                    continue;
                }

                if (String.IsNullOrEmpty(task))
                    continue;

                this.TasksList.Enqueue(task);
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
            bool isListFinshed = false;
            string book = string.Empty;
            while (!isListFinshed)
            {
                book = Console.ReadLine();

                if (book == " ")
                {
                    isListFinshed = true;
                    continue;
                }

                if (String.IsNullOrEmpty(book))
                    continue;

                this.BooksList.Push(book);
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
