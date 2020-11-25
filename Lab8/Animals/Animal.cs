using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    class Animal
    {
        public string Name { get; protected set; }
        public string FavouriteFood { get; protected set; }
        public Animal (string name, string food)
        {
            Name = name;
            FavouriteFood = food;
        }

        public virtual string ExplainSelf()
        {
            return $"I am  {Name} and my favourite food is {FavouriteFood}";
        }
    }
}
