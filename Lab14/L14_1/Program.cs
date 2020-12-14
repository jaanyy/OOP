using System;
using System.Linq;

namespace L14_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string r = new string(input.ToCharArray().Reverse().ToArray());
            Console.Write($"Variant I: {r}\n");
            Console.Write("Variant II: ");
            for (int i = input.Length - 1; i >= 0; i--)
            {
                Console.Write($"{input[i]}");
            }

            Console.ReadKey();
        }
    }
}
