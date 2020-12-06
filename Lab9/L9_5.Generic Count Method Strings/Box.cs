using System;
using System.Collections.Generic;
using System.Text;

namespace L9_5.Generic_Count_Method_Strings
{
    class Box<T> : IComparable<T>
    where T : IComparable<T>
    {
        public T Value { get; set; }

        public Box(T value)
        {
            Value = value;
        }

        public int CompareTo(T other)
        {
            return Value.CompareTo(other);
        }

        public override string ToString()
        {
            return $"{Value.GetType().FullName}: {Value}";
        }
    }
}
