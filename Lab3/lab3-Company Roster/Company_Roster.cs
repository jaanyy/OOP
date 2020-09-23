using System;

namespace lab3_Company_Roster
{
    class Employee
    {
        public string Name { get; set; }
        public double Salary { get; set; }
        public string Position { get; set; }
        public string Department { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }

        public Employee(string name, double salary, string position, string department, string email = "n/a", int age = -1)
        {
            Name = name;
            Salary = salary;
            Position = position;
            Department = department;
            Email = email;
            Age = age;
        }

    }
    class Company_Roster
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; ++i)
            {
                string[] input = Console.ReadLine().Split(' ');
                int t = input.Length;
                if (t == 4)
                {
                    Employee person = new Employee(input[0], Convert.ToDouble(input[1]), input[2], input[3]);
                }
                else if (t == 5)
                {
                    Employee person = new Employee(input[0], Convert.ToDouble(input[1]), input[3], input[4], (input[5]));
                }
                
                
            }
        }
    }
}
