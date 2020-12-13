using System;
using System.Text.RegularExpressions;

namespace L13_5_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"\b([\w\d][\w\d-._]*[\w\d])@([\w][\w-]*[\w]\.[\w][\w-.]*[\w])\b");
            
            string input = Console.ReadLine();
            MatchCollection matches = regex.Matches(input);
            if(matches.Count > 0)
            {
                foreach (Match match in matches)
                {
                    Console.WriteLine(match.Value);
                }
            }
            else
            {
                Console.WriteLine("There are no matches");
            }
            Console.ReadKey();
            //https://regex101.com/r/WqoGCF/3
        }
    }
}
