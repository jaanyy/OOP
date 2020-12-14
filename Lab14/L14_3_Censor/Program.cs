using System;
using System.Text.RegularExpressions;

namespace L14_3_Censor
{
    class Program
    {
        static void Main(string[] args)
        {
            string email = Console.ReadLine();
            string[] data = email.Split('@');
            string username = data[0];
            string domain = data[1];
            string censor = "";

            Regex regex = new Regex(@"(\S)");
            censor = regex.Replace(username, "*");

            string censoredEmail = censor + "@" + domain;

            string text = Console.ReadLine();

            text = text.Replace(email, censoredEmail);
            Console.WriteLine(text);

            Console.ReadKey();
        }
    }
}
