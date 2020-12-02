using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5_Pizza_Calories
{
    class Topping
    {
        private static readonly Dictionary<string, double> diffrentTypes;
        static Topping()
        {
            diffrentTypes = new Dictionary<string, double>
            {
                ["Meat"] = 1.2,
                ["Veggies"] = 0.8,
                ["Cheese"] = 1.1,
                ["Sauce"] = 0.9
            };
        }
        public string Type
        {
            get => Type;
            set
            {
                if (!diffrentTypes.ContainsKey(value))
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }   
                Type = value;
            }
        }
        public int Weight
        {
            get => Weight;
            private set
            {
                if (value < 1 || value > 50)
                {
                    throw new ArgumentException($"{Type} weight should be in the range [1..50].");
                }  
                Weight = value;
            }
        }
        const int baseCalories = 2;
        public Topping(string type, int weight)
        {
            Type = type;
            Weight = weight;
        }

        public double TotalCalories()
        {
            return (Weight * diffrentTypes[Type]);
        }
    }
}
