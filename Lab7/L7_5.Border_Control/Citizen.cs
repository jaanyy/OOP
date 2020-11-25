using System;
using System.Collections.Generic;
using System.Text;

namespace L7_5.Border_Control
{
    class Citizen : IIdenifiable
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public string Id { get; private set; }

        public Citizen(string name, int age, string id)
        {
            Name = name;
            Age = age;
            Id = id;
        }
    }
}
