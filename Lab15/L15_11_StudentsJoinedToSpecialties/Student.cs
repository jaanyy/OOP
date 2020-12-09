using System;
using System.Collections.Generic;
using System.Text;

namespace L15_11_StudentsJoinedToSpecialties
{
    class Student
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public int FacultyNumber { get; set; }

        public Student(int faculty, string firstName, string secondName)
        {
            FacultyNumber = faculty;
            FirstName = firstName;
            SecondName = secondName;
        }
    }
}
