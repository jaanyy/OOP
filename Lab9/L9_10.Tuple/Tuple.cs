﻿using System;
using System.Collections.Generic;
using System.Text;

namespace L9_10.Tuple
{
    class Tuple<T1, T2>
    {
        public T1 Item1 { get; }
        public T2 Item2 { get; }

        public Tuple(T1 item1, T2 item2)
        {
            Item1 = item1;
            Item2 = item2;
        }

        public override string ToString()
        {
            return $"{Item1} -> {Item2}";
        }
    }
}
