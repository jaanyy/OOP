using System;
using System.Collections.Generic;

namespace L14_13_Phonebook_
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();
            List <string> names = new List<string>();
            while (true)
            {
                string[] input = Console.ReadLine().Split(" ");
                if (input[0] == "END")
                {
                    break;
                }
                if (input[0] == "A")
                {
                    if (phoneBook.ContainsKey(input[1]))
                    {
                        phoneBook[input[1]] = input[2];
                    }
                    else
                    {
                        phoneBook.Add(input[1], input[2]);
                        names.Add(input[1]);
                    }
                }
                if (input[0] == "S")
                {
                    if (phoneBook.ContainsKey(input[1]))
                    {
                        Console.WriteLine($"{input[1]} -> {phoneBook[input[1]]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {input[1]} does not exist.");
                    }
                }
                if (input[0] == "ListAll")
                {
                    names.Sort();
                    foreach (string name in names)
                    {
                        Console.WriteLine($"{name} -> {phoneBook[name]}");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
