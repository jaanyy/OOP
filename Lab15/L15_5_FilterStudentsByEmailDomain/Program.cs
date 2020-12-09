using System;
using System.Collections.Generic;
using System.Linq;

namespace L15_5_FilterStudentsByEmailDomain
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                string[] input = command.Split();
                students.Add(new Student(input[0], input[1], input[2]));
            }
            var result = students.Where(s => s.Email.EndsWith("@gmail.com"));
            foreach (var r in result)
            {
                Console.WriteLine($"{r.FirstName} {r.SecondName}");
            }
            Console.ReadKey();
        }
    }
}
