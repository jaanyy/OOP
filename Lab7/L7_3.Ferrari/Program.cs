using System;

namespace L7_3.Ferrari
{
    class Program
    {
        static void Main(string[] args)
        {
            string driver = Console.ReadLine();
            var ferrari = new Ferrari(driver);
            Console.WriteLine($"{ferrari.Model} / {ferrari.UseBrakes()} / {ferrari.PushGas()} / {ferrari.Driver}"); ;

            Console.ReadKey();
        }
    }
}
