using System;
using System.Collections.Generic;
using System.Text;

namespace _5_Pizza_Calories
{
    class Pizza
    {
        public string Name 
        {
            get => Name;
            set
            {
                if (value.Length < 1 || value.Length > 15)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }

                Name = value;
            }
        }
        public Dough Dough { get; set; }
        private List<Topping> toppings;

        public Pizza(string name)
        {
            Name = name;
            toppings = new List<Topping>();
        }
        public void AddTopping(Topping topping)
        {
            if (toppings.Count == 10)
            {
                throw new ArgumentException("Number of toppings should be in range [0..10].");
            }
                
            toppings.Add(topping);
        }
        public double TotalCalories()
        {
            double sum = 0;
            sum += Dough.TotalCalories();
            toppings.ForEach(t => sum += t.TotalCalories());

            return sum;
        }
    }
}
