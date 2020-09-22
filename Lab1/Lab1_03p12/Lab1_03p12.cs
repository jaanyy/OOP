using System;
class Lab1_03p12
{
    static void Main()
    {
        int n = 0;
        bool result = false;
        Console.Write("n = ");
        n = Convert.ToInt32(Console.ReadLine());
        if (n>20 && n%2== 1)
        {
            result = true;
        }

        Console.WriteLine($"Result: {result}");

        Console.ReadKey();
    }
}