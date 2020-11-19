using System;
using System.Collections.Generic;
using System.Text;

namespace _3.Mankind
{
    class Student : Human
    {
        private int facultyNumber;

        public Student(string firstName, string lastName, int facultyNumber)
            : base(firstName, lastName)
        {
            FacultyNumber = facultyNumber;
        }

        private int FacultyNumber
        {
            get
            {
                return facultyNumber;
            }

            set
            {
                

                if (!(value > 10 || value < 5))
                {
                    throw new ArgumentException("Invalid faculty number!");
                }

                facultyNumber = value;
            }
        }

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.Append(base.ToString())
                .AppendLine($"Faculty number: {FacultyNumber}");

            return builder.ToString();
        }
    }
}
