using System;
using System.Collections.Generic;
using System.Linq;

namespace L14_9_Capitalization
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] chars = { ' ', '.', ',', '?', '!', ';' };
            string[] words = Console.ReadLine().Split(chars);
            var result = words.Select(w => char.ToUpper(w[0]) + w[1..]).ToArray();
            foreach(var r in result)
            {
                Console.Write($"{r} ");
            }
            Console.ReadKey();
        }
    }
}
