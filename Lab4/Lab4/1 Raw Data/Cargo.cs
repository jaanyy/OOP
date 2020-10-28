using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Raw_Data
{
    class Cargo
    {
        public int Weight { get; private set; }
        public string Type { get; private set; }

        public Cargo(int weight, string type)
        {
            Weight = weight;
            Type = type;
        }

    }
}
