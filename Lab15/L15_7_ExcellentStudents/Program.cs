using System;
using System.Collections.Generic;
using System.Linq;

namespace L15_7_ExcellentStudents
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
                List<int> marks = new List<int>();
                for (int i = 2; i < input.Length; i++)
                {
                    marks.Add(Convert.ToInt32(input[i]));
                }
                    
                students.Add(new Student(input[0], input[1], marks));
            }
            var result = students.Where(s => s.Marks.Any(m => m == 6));
            foreach(var r in result)
            {
                Console.WriteLine($"{r.FirstName} {r.SecondName}");
            }
            Console.ReadKey();
        }
    }
}
