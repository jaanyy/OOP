using System;
using System.Collections.Generic;
using System.Linq;

namespace L7_6.Birthday
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IBirthable> all = new List<IBirthable>();

            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                var input = command.Split();

                switch (input[0])
                {
                    case "Citizen":
                        all.Add(new Citizen(input[1], int.Parse(input[2]), input[3], input[4]));
                        break;
                    case "Pet":
                        all.Add(new Pet(input[1], input[2]));
                        break;

                }
            }

            string year = Console.ReadLine();

            foreach (var i in all)
            {
                if (i.Birthdate[6] == year[0] && i.Birthdate[7] == year[1] && i.Birthdate[8] == year[2] && i.Birthdate[9] == year[3])
                {
                    Console.WriteLine(i.Birthdate);
                }
            }
            Console.ReadKey();

        }
    }
}
