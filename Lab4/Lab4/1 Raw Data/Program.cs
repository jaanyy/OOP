using System;
using System.Collections.Generic;
using System.Linq;

namespace _1_Raw_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < N; i++)
            {
                var input = Console.ReadLine().Split();

                string model = input[0];
                int speed = Convert.ToInt32(input[1]);
                int power = Convert.ToInt32(input[2]);
                int weight = Convert.ToInt32(input[3]);
                string type = input[4];
                List<Tire> tires = new List<Tire>();

                for (int j = 5; j < input.Length; j += 2)
                {
                    double pressure = Convert.ToDouble(input[j].Replace('.', ','));
                    int age = Convert.ToInt32(input[j + 1]);

                    tires.Add(new Tire(pressure, age));
                }

                Engine engine = new Engine(speed, power);
                Cargo cargo = new Cargo(weight, type);

                cars.Add(new Car(model, engine, cargo, tires));
            }

            string command = Console.ReadLine();

            if (command == "fragile")
            {
                cars.Where(c => c.Cargo.Type == "fragile" && c.Tires.Any(t => t.Pressure < 1))
                    .Select(c => c.Model).ToList().ForEach(Console.WriteLine);
            }
            else if (command == "flamable")
            {
                cars.Where(c => c.Cargo.Type == "flamable" && c.Engine.Power > 250).Select(c => c.Model).ToList()
                    .ForEach(Console.WriteLine);
            }

            Console.ReadKey();
        }
    }
}
