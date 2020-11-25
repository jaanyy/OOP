using System;
using System.Collections.Generic;
using System.Text;

namespace L7_2.Multiple_Implementation
{
    class Citizen : IPerson, IIdentifiable, IBirthable
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Id { get; set; }
        public string Birthdate { get; set; }
        public Citizen(string name, int age, string id, string birth)
        {
            Name = name;
            Age = age;
            Id = id;
            Birthdate = birth;
        }
    }
}
