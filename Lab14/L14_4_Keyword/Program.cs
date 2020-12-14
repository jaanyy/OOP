using System;

namespace L14_4_Keyword
{
    class Program
    {
        static void Main(string[] args)
        {
            string keyword = Console.ReadLine();
            string text = Console.ReadLine();
            char[] chars = { '.', '!', '?' };
            string[] sentences = text.Split(chars);
            int n = sentences.Length;  
            for (int i = 0; i < n; i++)
            {
                string[] words = sentences[i].Split(" ");
                bool isFound = false;
                for (int j = 0; j < words.Length; j++)
                {
                    if (words[j] == keyword)
                    {
                        isFound = true;
                        break;
                    }
                }
                if (isFound)
                    Console.WriteLine(sentences[i]);
            }
            Console.ReadKey();
        }
    }
}
