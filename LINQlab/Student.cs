using System;
using System.Collections.Generic;
using System.Text;

namespace LINQlab
{
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Student(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
