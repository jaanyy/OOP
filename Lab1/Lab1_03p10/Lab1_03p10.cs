using System;
class Lab1_03p10
{
    static void Main()
    {
        int n = 0, lastDigit = 0;
        Console.Write("n = ");
        n = Convert.ToInt32(Console.ReadLine());
        lastDigit = n % 10;
        Console.WriteLine($"Last digit is {lastDigit}");
        Console.ReadKey();
    }
}
