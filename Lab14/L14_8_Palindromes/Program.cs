using System;
using System.Collections.Generic;
using System.Linq;

namespace L14_8_Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] chars = { ' ', ',', '.', '?', '!' };
            string[] words = Console.ReadLine().Split(chars);
            List<string> palindromes = new List<string>();
            for (int i = 0; i < words.Length; i++)
            {
               if (words[i] == new string(words[i].ToCharArray().Reverse().ToArray()))
                {
                    palindromes.Add(words[i]);
                }
                    
            }   
            foreach (string word in palindromes)
            {
                Console.Write($"{word}");
                if (word != palindromes.Last())
                {
                    Console.Write(", ");
                }    
            }
            Console.ReadKey();
        }
    }
}
