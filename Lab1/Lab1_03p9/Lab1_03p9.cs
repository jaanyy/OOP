using System;
class Lab1_03p9
{
    static void Main()
    {
        double a = 0.0, b = 0.0, h = 0.0, area = 0.0;
        Console.Write("a = ");
        a = Convert.ToDouble(Console.ReadLine());
        Console.Write("b = ");
        b = Convert.ToDouble(Console.ReadLine());
        Console.Write("h = ");
        h = Convert.ToDouble(Console.ReadLine());
        area = (float)(((a + b) / 2.0) * h);

        Console.WriteLine($"Area is {area}");

        Console.ReadKey();
    }
}