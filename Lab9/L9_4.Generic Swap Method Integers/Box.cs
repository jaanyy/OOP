using System;
using System.Collections.Generic;
using System.Text;

namespace L9_4.Generic_Swap_Method_Integers
{
    class Box<T>
    {
        private T value;
        public Box(T value)
        {
            this.value = value;
        }
        public override string ToString()
        {
            return $"{this.value.GetType().FullName}: {this.value}";
        }
    }
}
