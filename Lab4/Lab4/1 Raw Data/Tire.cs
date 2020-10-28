using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Raw_Data
{
    class Tire
    {
        public double Pressure { get; private set; }
        public int Age { get; private set; }

        public Tire(double pressure, int age)
        {
            Pressure = pressure;
            Age = age;
        }

     }
}
