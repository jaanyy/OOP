using System;
using System.Text.RegularExpressions;

namespace L13_4_ReplaceTag
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"<a");
            string command = "";
            string input = "";
            while ((command = Console.ReadLine()) != "end")
            {
                input += command;
            }
            string result = regex.Replace(input, $"[URL ");
            result = result.Replace("</a>", "[/URL]");
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
