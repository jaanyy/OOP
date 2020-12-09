using System;
using System.Collections.Generic;
using System.Text;

namespace L15_9_StudentsEnrolled
{
    class Student
    {
        public string FacultyNumber { get; set; }
        public List<int> Marks { get; set; }
        public Student(string facultyNumber,  List<int> marks)
        {
            FacultyNumber = facultyNumber;
            Marks = marks;
        }
    }
}
