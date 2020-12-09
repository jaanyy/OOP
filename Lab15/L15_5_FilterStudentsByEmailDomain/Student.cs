using System;
using System.Collections.Generic;
using System.Text;

namespace L15_5_FilterStudentsByEmailDomain
{
    class Student
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Email { get; set; }
        public Student(string firstName, string lastName, string email)
        {
            FirstName = firstName;
            SecondName = lastName;
            Email = email;
        }
    }
}
