using System;
class Lab2p9
{
    static void Main()
    {
        string array = Console.ReadLine();
        char[] A = new char[array.Length];
        
        for (int i = 0; i < array.Length; ++i)
        {
            Console.WriteLine($"{array[i]} -> {(int)array[i]-97}");
        }
        Console.ReadKey();
    }
}
