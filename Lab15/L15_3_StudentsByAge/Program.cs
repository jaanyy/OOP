using System;
using System.Collections.Generic;
using System.Linq;

namespace L15_3_StudentsByAge
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
                students.Add(new Student(input[0], input[1], Convert.ToInt32(input[2])));
            }
            var result = StudentByAge(students);
            foreach (var r in result)
            {
                Console.WriteLine($"{r.FirstName} {r.SecondName} {r.Age}");
            }

            Console.ReadKey();
        }
        static IEnumerable<Student> StudentByAge(List<Student> studs)
        {
            var result = studs.Where(s => s.Age >= 18 && s.Age <= 24);

            return result;
        }
    }
}
