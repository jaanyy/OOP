using System;
using System.Collections.Generic;

namespace L14_12_Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();
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
            }
            Console.ReadKey();
        }
    }
}
