using System;
using System.Collections.Generic;
using System.Text;

namespace L7_6.Birthday
{
    class Pet : INameable, IBirthable
    {
        public string Birthdate { get; private set; }
        public string Name { get; private set; }
        public Pet(string name, string birth)
        {
            Name = name;
            Birthdate = birth;
        }
    }
}
