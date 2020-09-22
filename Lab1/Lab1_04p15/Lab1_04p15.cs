using System;
class Lab1_04p15
{
    static void Main()
    {
        double a = 0.0, b = 0.0, c = 0.0;
        string product = "";
        int neg = 0;
        Console.Write("a = ");
        a = Convert.ToDouble(Console.ReadLine());
        Console.Write("b = ");
        b = Convert.ToDouble(Console.ReadLine());
        Console.Write("c = ");
        c = Convert.ToDouble(Console.ReadLine());
        if (a < 0) neg++;
        if (b < 0) neg++;
        if (c < 0) neg++;

        if(neg==1 || neg==3)
        {
            product = "Negative";
        }
        else
        {
            product = "Positive";
        }
        Console.WriteLine($"Result is {product}.");
        Console.ReadKey();
    }
}
