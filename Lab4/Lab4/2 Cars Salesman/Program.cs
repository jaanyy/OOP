using System;
using System.Collections.Generic;
using System.Linq;

namespace _2_Cars_Salesman
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();

            for (int i = 0; i < N; i++)
            {
                var input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string model = input[0];
                int power = Convert.ToInt32(input[1]);

                if (input.Length == 2)
                {
                    engines.Add(new Engine(model, power));
                }
                else if (input.Length == 3)
                {
                    if (input[2].All(Char.IsDigit))
                    {
                        int displacement = Convert.ToInt32(input[2]);
                        engines.Add(new Engine(model, power, displacement));
                    }
                    else
                    {
                        string efficiency = input[2];
                        engines.Add(new Engine(model, power, efficiency));
                    }
                }
                else if (input.Length == 4)
                {
                    int displacement = Convert.ToInt32(input[2]);
                    string efficiency = input[3];

                    engines.Add(new Engine(model, power, displacement, efficiency));
                }
            }

            N = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                var input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string model = input[0];
                Engine engine = engines.First(e => e.Model == input[1]);

                if (input.Length == 2)
                {
                    cars.Add(new Car(model, engine));
                }
                else if (input.Length == 3)
                {
                    if (input[2].All(Char.IsDigit))
                    {
                        int weight = Convert.ToInt32(input[2]);

                        cars.Add(new Car(model, engine, weight));
                    }
                    else
                    {
                        string color = input[2];

                        cars.Add(new Car(model, engine, color));
                    }
                }
                else if (input.Length == 4)
                {
                    int weight = Convert.ToInt32(input[2]);
                    string color = input[3];

                    cars.Add(new Car(model, engine, weight, color));
                }
            }

            cars.ForEach(Console.WriteLine);
            Console.ReadKey();
        }

        
        }
    }

