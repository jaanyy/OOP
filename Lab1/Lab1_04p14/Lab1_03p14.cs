using System;
class Lab1_03p14
{
    static void Main()
    {
        int a = 0, b = 0, c = 0, max = 0;
        Console.Write("First number is ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Second number is ");
        b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Third number is ");
        c = Convert.ToInt32(Console.ReadLine());
        max = a;
        if(b>a)
        {
            max = b;
        }
        if(c>a)
        {
            max = c;
        }
        Console.WriteLine($"Maximum is {max}");
        Console.ReadKey();
    }
}