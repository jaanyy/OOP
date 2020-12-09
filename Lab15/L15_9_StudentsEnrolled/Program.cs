using System;
using System.Collections.Generic;
using System.Linq;

namespace L15_9_StudentsEnrolled
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
                for (int i = 1; i < input.Length; i++)
                {
                    marks.Add(Convert.ToInt32(input[i]));
                }

                students.Add(new Student(input[0], marks));
            }

            var result = students.Where(s => s.FacultyNumber.EndsWith("14") || s.FacultyNumber.EndsWith("15"));

            foreach (var r in result)
            {
                foreach(var m in r.Marks)
                {
                    Console.Write($"{m} ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
