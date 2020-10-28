using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Raw_Data
{
    class Car
    {
        public string Model { get; private set; }
        public Engine Engine { get; private set; }
        public Cargo Cargo { get; private set; }
        public List<Tire> Tires { get; private set; }

        public Car(string model, Engine engine, Cargo cargo, List<Tire> tires)
        {
            this.Model = model;
            this.Engine = engine;
            this.Cargo = cargo;
            this.Tires = tires;
        }
    }
}
