using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5_Pizza_Calories
{
    class Dough
    {
        private static readonly Dictionary<string, double> flourTypes;
        private static readonly Dictionary<string, double> bakingTechniques;
        static Dough()
        {
            flourTypes = new Dictionary<string, double>
            {
                ["White"] = 1.5,
                ["Wholegrain"] = 1.0
            };

            bakingTechniques = new Dictionary<string, double>
            {
                ["Crispy"] = 0.9,
                ["Chewy"] = 1.1,
                ["Homemade"] = 1.0
            };
        }
        public string Type
        {
            get => Type;
            set
            {
                if (!flourTypes.ContainsKey(value))
                {
                    throw new ArgumentException("Invalid type of dough.");
                }   
                Type = value;
            }
        }
        public string Technique
        {
            get => Technique;
            set
            {
                if (!bakingTechniques.ContainsKey(value))
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                Technique = value;
            }
        }
        public int Weight {
            get => Weight; 
            set
            {
                if (value > 200 || value < 1)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }
                Weight = value;
            }
        }
        const int baseCalories = 2;
        public Dough(string flourType, string bakingTechnique, int weight)
        {
            Type = flourType;
            Technique = bakingTechnique;
            Weight = weight;
        }
        public double TotalCalories()
        {

            return (baseCalories * Weight * flourTypes[Type] * bakingTechniques[Technique]);
        }
    }
}
