using System;
using System.Collections.Generic;

namespace lab3_Raw_Data
{
    class Engine
    {
        public int Speed { get; set; }
        public int Power { get; set; }
        public Engine(int sp, int p)
        {
            Speed = sp;
            Power = p;
        }
    }
    class Cargo
    {
        public int Weight { get; set; }
        public string Type { get; set; }
        public Cargo(int w, string t)
        {
            Weight = w;
            Type = t;
        }
    }
    class Tire
    {
        public double Pressure { get; set; }
        public int Age { get; set; }
        public Tire(double pres, int age)
        {
            Pressure = pres;
            Age = age;
        }
    }
    class Car
    {
        public string Model { get; set; }
        public Engine CarEngine { get; set; }
        public Cargo CarCargo { get; set; }
        public Tire[] CarTires { get; set; }

        public bool IsLess(int value)
        {
            foreach (var tire in CarTires)
            {
                if (tire.Pressure < value)
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsGreater(int value)
        {
            return CarEngine.Power > value;
        }

        public Car(string model, Engine engine, Cargo cargo, Tire[] tires)
        {
            Model = model;
            CarEngine = engine;
            CarCargo = cargo;
            CarTires = tires;
        }
    }
    class Raw_Data
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');

                string model = input[0];
                Engine engine = new Engine(Convert.ToInt32(input[1]), Convert.ToInt32(input[2]));
                Cargo cargo = new Cargo(Convert.ToInt32(input[3]), input[4]);
                Tire[] tires = new Tire[4];
                for (int j = 0, k = 5; j < 4; j++, k += 2)
                {
                    double pressure = Convert.ToDouble(input[k].Replace('.', ','));
                    int age = Convert.ToInt32(input[k + 1]);
                    tires[j] = new Tire(pressure, age);
                }

                cars.Add(new Car(model, engine, cargo, tires));
            }

            string command = Console.ReadLine();
            switch (command)
            {
                case "fragile":
                    foreach (var car in cars)
                    {
                        if (car.CarCargo.Type.Equals(command) && car.IsLess(1))
                        {
                            Console.WriteLine(car.Model);
                        }
                    }
                    break;
                case "flamable":
                    foreach (var car in cars)
                    {
                        if (car.CarCargo.Type.Equals(command) && car.IsGreater(250))
                        {
                            Console.WriteLine(car.Model);
                        }
                    }
                    break;
            }

            Console.ReadKey();
        }
    }
}
