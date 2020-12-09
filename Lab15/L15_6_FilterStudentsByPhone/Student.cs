using System;
using System.Collections.Generic;
using System.Text;

namespace L15_6_FilterStudentsByPhone
{
    class Student
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Phone { get; set; }
        public Student(string firstName, string lastName, string phone)
        {
            FirstName = firstName;
            SecondName = lastName;
            Phone = phone;
        }
    }
}
