using System;
class Lab1_03p8
{
    static void Main()
    {
        int a = 0, b = 0, c = 0;
        float average = 0.0f;
        Console.Write("a = ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("b = ");
        b = Convert.ToInt32(Console.ReadLine());
        Console.Write("c = ");
        c = Convert.ToInt32(Console.ReadLine());
        average = (float)((a + b + c) / 3.0);

        Console.WriteLine($"Average is {average}");

        Console.ReadKey();
    }
}
