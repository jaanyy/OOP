using System;
using System.Collections.Generic;
using System.Text;

namespace L7_7.Food_Shortage
{
    class Rebel : IBuyer, IAgeable
    {
        public string Group { get; private set; }
        public string Name { get; private set; }
        public int Food { get; private set; }
        public int Age { get; private set; }
        public Rebel(string name, int age, string group)
        {
            Name = name;
            Age = age;
            Group = group;
        }
        public void BuyFood()
        {
            Food += 5;
        }
    }
}
