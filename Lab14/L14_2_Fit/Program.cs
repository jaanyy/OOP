﻿using System;

namespace L14_2_Fit
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            if (input.Length < 20)
                input = input.PadRight(20, '*');
            else
                input = input.Substring(0, 20);
            Console.WriteLine(input);
            Console.ReadKey();
        }
    }
}
