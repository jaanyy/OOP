using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Raw_Data
{
    class Engine
    {
        public int Speed { get; private set; }
        public int Power { get; private set; }

        public Engine(int speed, int power)
        {
            Speed = speed;
            Power = power;
        }

    }
}
