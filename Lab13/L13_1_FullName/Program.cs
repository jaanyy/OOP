using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace L13_1_FullName
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            List<string> result = new List<string>();
            Regex regex = new Regex(@"\b[A-Z][a-z]+[ ][A-Z][a-z]+\b");
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }
                else
                {
                    input += command + " , ";
                }
            }
            MatchCollection matches = regex.Matches(input);
            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                {
                    Console.WriteLine(match.Value);
                }
            }
            else
            {
                Console.WriteLine("Совпадений не найдено");
            }
            
        

            Console.ReadKey();
            //https://regex101.com/r/KqO2XX/1
        }
    }
}
