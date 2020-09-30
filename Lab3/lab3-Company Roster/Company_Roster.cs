using System;
using System.Collections.Generic;

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
        public Employee(string name, double salary, string position, string department)
                : this(name, salary, position, department, "n/a", -1) { }
        public Employee(string name, double salary, string position, string department, string email)
            : this(name, salary, position, department, email, -1) { }
        public Employee(string name, double salary, string position, string department, int age)
            : this(name, salary, position, department, "n/a", age) { }

        public Employee(string name, double salary, string position, string department, string email = "n/a", int age = -1)
        {
            Name = name;
            Salary = salary;
            Position = position;
            Department = department;
            Email = email;
            Age = age;
        }
        //
        



    }
    class Company
    {
        private List<Employee> employees;
        public Company()
        {
            employees = new List<Employee>();
        }
        public void AddEmployee(string[] data)
        {
            int length = data.Length;
            if (length == 4)
            {
                employees.Add(new Employee(data[0], Convert.ToDouble(data[1].Replace('.', ',')), data[2], data[3]));
            }
            if (length == 5)
            {
                if(int.TryParse(data[4], out int age))
                {
                    employees.Add(new Employee(data[0], Convert.ToDouble(data[1].Replace('.', ',')), data[2], data[3], age));
                }
                else
                {
                    employees.Add(new Employee(data[0], Convert.ToDouble(data[1].Replace('.', ',')), data[2], data[3], data[4]));
                }
            }
            if (length == 6)
            {
                employees.Add(new Employee(data[0], Convert.ToDouble(data[1].Replace('.', ',')), data[2], data[3], data[4], Convert.ToInt32(data[5])));
            }
        }
        private string BestDeparture ()
        {
            string bestDep = "";
            double bestSal = 0;
            List<string> deps = new List<string>();
            foreach(var a in employees)
            {
                if (!deps.Contains(a.Department))
                {
                    deps.Add(a.Department);
                }
            }
            foreach(var a in deps)
            {
                double tempSal = 0;
                int count = 0;
                foreach(var b in employees)
                {
                    if (b.Department == a)
                    {
                        tempSal += b.Salary;
                        count++;
                    }
                }
                tempSal /= count;
                if(tempSal > bestSal)
                {
                    bestSal = tempSal;
                    bestDep = a;
                }
            }
            return bestDep;
        }
        private List<Employee> listBest (string depart)
        {
            List<Employee> result = new List<Employee>();
            foreach (var a in employees)
            {
                if (a.Department == depart)
                {
                    result.Add(a);
                }
            }
            return result;
        }
        private void SortBySalary(ref List<Employee> best)
        {
            for(int i = 0; i < best.Count-1; ++i)
            {
                if (best[i].Salary < best[i+1].Salary)
                {
                    Employee temp = best[i];
                    best[i] = best[i + 1];
                    best[i + 1] = temp;
                }
            }
        }

        public void PrintResult ()
        {
            string bestD = BestDeparture();
            Console.WriteLine($"Highest Average Salary: {bestD}");
            List<Employee> best = listBest(bestD);
            SortBySalary(ref best);
            for (int i = 0; i < best.Count; ++i)
            {
                Console.WriteLine($"{best[i].Name} {best[i].Salary} {best[i].Email} {best[i].Age}");
            }

        }

    }
    
    class Company_Roster
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            Company company = new Company();
            for (int i = 0; i < N; ++i)
            {
                string[] input = Console.ReadLine().Split(' ');
                company.AddEmployee(input);
            }
            company.PrintResult();
            


            Console.ReadKey();
        }
    }
}
