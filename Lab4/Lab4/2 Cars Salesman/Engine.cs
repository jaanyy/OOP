using System;
using System.Collections.Generic;
using System.Text;

namespace _2_Cars_Salesman
{
    class Engine
    {
        public string Model { get; private set; }
        private int power;
        private int? displacement;
        private string efficiency;

        public Engine(string model, int power)
        {
            Model = model;
            this.power = power;
        }

        public Engine(string model, int power, int? displacement)
            : this(model, power)
        {
            this.displacement = displacement;
        }

        public Engine(string model, int power, string efficiency)
            : this(model, power)
        {
            this.efficiency = efficiency;
        }

        public Engine(string model, int power, int? displacement, string efficiency)
            : this(model, power)
        {
            this.displacement = displacement;
            this.efficiency = efficiency;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine($"  {Model}:");
            builder.AppendLine($"    Power: {power}");
            builder.AppendLine($"    Displacement: {(displacement == null ? "n/a" : displacement.ToString())}");
            builder.AppendLine($"    Efficiency: {(efficiency == null ? "n/a" : efficiency.ToString())}");

            return builder.ToString();
        }
    }
}
