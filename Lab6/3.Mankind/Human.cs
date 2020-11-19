using System;
using System.Collections.Generic;
using System.Text;

namespace _3.Mankind
{
    class Human
    {
        private string firstName;
        private string lastName;

        public Human(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                if (!Char.IsUpper(value[1]))
                {
                    throw new ArgumentException("Expected upper case letter! Argument: firstName");
                }

                if (value.Length <= 3)
                {
                    throw new ArgumentException("Expected length at least 4 symbols! Argument: firstName");
                }

                firstName = value;
            }
        }

        protected string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                if (!Char.IsUpper(value[1]))
                {
                    throw new ArgumentException("Expected upper case letter! Argument: lastName");
                }

                if (value.Length <= 2)
                {
                    throw new ArgumentException("Expected length at least 3 symbols! Argument: lastName");
                }

                lastName = value;
            }
        }

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendLine($"First Name: {FirstName}")
                .AppendLine($"Last Name: {LastName}");

            return builder.ToString();
        }
    }
}
