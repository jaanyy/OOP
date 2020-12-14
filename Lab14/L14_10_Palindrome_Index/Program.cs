using System;
using System.Linq;

namespace L14_10_Palindrome_Index
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine().ToLower();
            int result = 0;
            if (a == new string(a.ToCharArray().Reverse().ToArray()))
            {
                Console.WriteLine(-1);
            }
            else
            {
                for (int i = 0; i < a.Length; i++)
                {
                    string b = a.Remove(i);
                    if (b == new string(b.ToCharArray().Reverse().ToArray()))
                    {
                        result = i;
                    }
                        
                }
                Console.WriteLine(result);
            }
            
            Console.ReadKey();
        }
    }
}
