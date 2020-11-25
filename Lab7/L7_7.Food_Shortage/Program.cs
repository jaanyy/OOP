using System;
using System.Collections.Generic;
using System.Linq;

namespace L7_7.Food_Shortage
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IBuyer> buyers = new List<IBuyer>();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                var input = Console.ReadLine().Split();

                if (input.Length == 4)
                {
                    buyers.Add(new Citizen(input[0], int.Parse(input[1]), input[2], input[3]));
                }
                else if (input.Length == 3)
                {
                    buyers.Add(new Rebel(input[0], int.Parse(input[1]), input[2]));
                }
            }

            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                var buyer = buyers.SingleOrDefault(b => b.Name == command);

                if (buyer != null)
                {
                    buyer.BuyFood();
                }
            }

            Console.WriteLine(buyers.Sum(b => b.Food));

            Console.ReadKey();
        }
    }
}
