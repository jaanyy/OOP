using System;

namespace _5_Pizza_Calories
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var input = Console.ReadLine().Split();
                Pizza pizza = new Pizza(input[1]);
                input = Console.ReadLine().Split();
                pizza.Dough = new Dough(input[1], input[2], Convert.ToInt32(input[3]));

                string command;
                while ((command = Console.ReadLine()) != "END")
                {
                    input = command.Split();
                    pizza.AddTopping(new Topping(input[1], Convert.ToInt32(input[2])));
                }
                Console.WriteLine(pizza);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
