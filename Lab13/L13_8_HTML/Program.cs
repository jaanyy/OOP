using System;
using System.Text.RegularExpressions;

namespace L13_8_HTML
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            string data = "";
            Regex regex = new Regex($@"<div(.*?)\s+(?:id|class)\s*=\s*([\'])(\w+)\2\s*(\s.*?)?\s*>(.*?)<\/div>\s*<!--\s*\3\s*-->");
            while ((input = Console.ReadLine()) == "END")
            {
                data += input;
            }
            string result = "";
            while (regex.IsMatch(result))
                result = regex.Replace(result, $"<$3$1$4>$5</$3>");
            Console.WriteLine(result);
            
            Console.ReadKey();
            //https://regex101.com/r/DpLdJk/1
        }
    }
}
