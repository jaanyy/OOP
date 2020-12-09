using System;
using System.Collections.Generic;
using System.Linq;

namespace L15_10_GroupByGroup
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> students = new List<Person>();
            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                string[] input = command.Split();
                students.Add(new Person(input[0]+input[1], Convert.ToInt32(input[2])));
            }

            var result = students.OrderBy(s => s.Group).GroupBy(s => s.Group);

            foreach (var r in result)
            {
                Console.Write($"{r.Key} - ");
                foreach (var g in r)
                {
                    Console.Write($"{g.Name}");
                    if (g != r.Last())
                    {
                        Console.Write(", ");
                    }
                        
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
