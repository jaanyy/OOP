using System;
using System.Text.RegularExpressions;

namespace L13_3_SeriesOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"(\w)\1+");
            string input = Console.ReadLine();
            string result = regex.Replace(input, $"$1");
            Console.WriteLine(result);
            Console.ReadKey();
            //https://regex101.com/r/7hE8b2/2
        }
    }
}
