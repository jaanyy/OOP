using System;
using System.Collections.Generic;
using System.Text;

namespace L7_7.Food_Shortage
{
    class Citizen : IIdenifiable, IBirthable, IBuyer, IAgeable
    {
        public string Id { get; private set; }
        public string Birthdate { get; private set; }
        public string Name { get; private set; }
        public int Food { get; private set; }
        public int Age { get; private set; }
        public void BuyFood()
        {
            Food += 10;
        }
        public Citizen(string name, int age, string id, string birth)
        {
            Name = name;
            Age = age;
            Id = id;
            Birthdate = birth;
        }
    }
}

