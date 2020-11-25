using System;
using System.Collections.Generic;
using System.Linq;

namespace L7_5.Border_Control
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IIdenifiable> all = new List<IIdenifiable>();

            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                var input = command.Split();

                if (input.Length == 3)
                {
                    all.Add(new Citizen(input[0], int.Parse(input[1]), input[2]));
                }
                else if (input.Length == 2)
                {
                    all.Add(new Robot(input[0], input[1]));
                }
            }

            string lastDigits = Console.ReadLine();
            List<string> result = new List<string>();
            all.Where(c => c.Id.EndsWith(lastDigits))
                .Select(c => c.Id)
                .ToList()
                .ForEach(Console.WriteLine);
            Console.ReadKey();
        }
    }
}
