using System;
using System.Collections.Generic;
using System.Text;

namespace L9_3.Generic_Swap_Method_Strings
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
