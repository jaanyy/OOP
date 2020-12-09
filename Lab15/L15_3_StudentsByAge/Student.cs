using System;
using System.Collections.Generic;
using System.Text;

namespace L15_3_StudentsByAge
{
    class Student
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public int Age { get; set; }
        public Student(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            SecondName = lastName;
            Age = age;
        }
        
    }
}
