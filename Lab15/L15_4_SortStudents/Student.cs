using System;
using System.Collections.Generic;
using System.Text;

namespace L15_4_SortStudents
{
    class Student
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public Student(string firstName, string lastName)
        {
            FirstName = firstName;
            SecondName = lastName;
        }
    }
}
