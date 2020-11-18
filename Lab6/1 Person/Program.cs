using System;

namespace _1_Person
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = Convert.ToInt32(Console.ReadLine());

            try
            {
                Child child = new Child(name, age);
                Console.WriteLine(child);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
