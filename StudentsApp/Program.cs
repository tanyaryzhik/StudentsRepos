﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Student st1 = new Student("Tom", "Smith", "math", 1, 2);
            ManagerOfStudentsList manager = new ManagerOfStudentsList();
            manager.Add(st1);
            manager.Add(new Student("John", "Dowson", "physics", 5, 1));
            manager.DisplayStudentsList();
        }
    }
}
