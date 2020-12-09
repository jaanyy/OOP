using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace L15_4_SortStudents
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
                students.Add(new Student(input[0], input[1]));
            }
            var result = students.OrderBy(s => s.SecondName)
                                 .ThenByDescending(s => s.FirstName);
            foreach (var r in result)
            {
                Console.WriteLine($"{r.FirstName} {r.SecondName}");
            }
            Console.ReadKey();
        }
    }
}
