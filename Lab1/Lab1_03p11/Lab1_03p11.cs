using System;
class Lab1_03p11
{
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        int Number = 0, n = 0, nDigit = 0;
        
        Console.Write("number = ");
        Number = Convert.ToInt32(Console.ReadLine());
        Console.Write("n = ");
        n = Convert.ToInt32(Console.ReadLine());
        nDigit = (int)(Number / System.Math.Pow(10, n - 1))%10;
        if (n<Number.ToString().Length)
        {
            Console.WriteLine($"This number is {nDigit}");
        }
        else
            Console.WriteLine("-");


        Console.ReadKey();
    }
}
