using System;
using System.Collections.Generic;
using System.Text;

namespace L15_1_StudentsByGroup
{
    class Student
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public int GroupNumber { get; set; }
        public Student(string firstName, string lastName, int group)
        {
            FirstName = firstName;
            SecondName = lastName;
            GroupNumber = group;
        }
    }
}
