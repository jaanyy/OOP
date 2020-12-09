using System;
using System.Collections.Generic;
using System.Text;

namespace L15_7_ExcellentStudents
{
    class Student
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public List<int> Marks { get; set; }
        public Student(string firstName, string lastName, List<int> marks)
        {
            FirstName = firstName;
            SecondName = lastName;
            Marks = marks;
        }
    }
}
