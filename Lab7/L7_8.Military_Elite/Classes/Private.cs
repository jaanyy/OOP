﻿using System;
using System.Collections.Generic;
using System.Text;

namespace L7_8.Military_Elite.Classes
{
    class Private : Soldier, IPrivate
    {
        public Private(string id, string firstName, string lastName, double salary)
        : base(id, firstName, lastName)
        {
            Salary = salary;
        }
        public double Salary { get; private set; }
        public override string ToString()
        {
            return $"{base.ToString()} Salary: {Salary:F2}";
        }
    }
}
