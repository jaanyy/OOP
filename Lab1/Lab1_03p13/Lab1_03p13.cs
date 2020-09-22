using System;
class Lab1_03p13
{
    static void Main()
    {
        int n = 0;
        bool result = false;
        Console.Write("n = ");
        n = Convert.ToInt32(Console.ReadLine());
        if (n % 9 == 0 || n % 11 == 0 || n % 13 == 0)
        {
            result = true;
        }

        Console.WriteLine($"Result: {result}");

        Console.ReadKey();
    }
}