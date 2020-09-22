using System;
class Lab1_05p17
{
    static void Main()
    {
        int n = 0, factorial = 1, i = 2;
        Console.Write("Your number is ");
        n = Convert.ToInt32(Console.ReadLine());
        while(i<=n)
        {
            factorial *= i;
            ++i;
        }
        Console.WriteLine($"Result is {factorial}.");
        Console.ReadKey();
    }
}
