using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace L13_2_PhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            List<string> result = new List<string>();
            Regex regex = new Regex(@"\+359([ ]2[ ]\d{3}[ ]\d{4}|[-]2[-]\d{3}[-]\d{4})\b");
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
                Console.WriteLine("There is no matches");
            }
            Console.ReadKey();
        }
    }
}
