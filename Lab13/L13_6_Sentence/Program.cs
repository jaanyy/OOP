using System;
using System.Text.RegularExpressions;

namespace L13_6_Sentence
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex key = new Regex($@"\b{Console.ReadLine()}\b");
            Regex regex = new Regex(@"\b.+?[?!.]");
            foreach (var i in regex.Matches(Console.ReadLine()))
                if (key.IsMatch(i.ToString()))
                    Console.WriteLine(i);
            Console.ReadKey();
            //https://regex101.com/r/2lA1n0/1
        }
    }
}
