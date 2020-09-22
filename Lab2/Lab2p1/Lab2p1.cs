using System;
using System.Data.SqlTypes;

class Lab2p1
{
    static void Main()
    {
        int count1 = 0, count2 = 0, n = 0;
        Console.Write("1. ");
        string[] s1 = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
        Console.Write("2. ");
        string[] s2 = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
        if (s1.Length < s2.Length)
        {
            n = s1.Length;
        }
        else n = s2.Length;

        for (int i = 0; i < n; ++i)
        {
            if (s1[i] == s2[i])
            {
                count1++;
            }
        }
        for (int i = n-1; i >= 0; --i)
        {
            if (s1[i] == s2[i])
            {
                count2++;
            }
        }
        if (count1 == 0 && count2 == 0)
        {
            Console.WriteLine("0");
        }
        else if (count1 > count2)
        {
            Console.WriteLine(count1);
        }
        else
        {
            Console.WriteLine(count2);
        }

        Console.ReadKey();
    }
}
