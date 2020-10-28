using System;

namespace _3_Animal_Farm
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = Convert.ToInt32(Console.ReadLine());

            try
            {
                Chicken chicken = new Chicken(name, age);
                Console.WriteLine("Chicken {0} (age {1}) can produce {2} eggs per day.", chicken.Name, chicken.Age, chicken.ProductPerDay);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
