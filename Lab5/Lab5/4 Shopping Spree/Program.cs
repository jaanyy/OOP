using System;
using System.Collections.Generic;
using System.Linq;

namespace _4_Shopping_Spree
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(';');
            List<Person> persons = new List<Person>();
            List<Product> products = new List<Product>();

            foreach (var p in input)
            {
                var input2 = p.Split('=');

                try
                {
                    persons.Add(new Person(input2[0], decimal.Parse(input2[1])));
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    return;
                }
            }

            input = Console.ReadLine().Split(';');

            foreach (var p in input)
            {
                var data = p.Split('=');

                try
                {
                    products.Add(new Product(data[0], decimal.Parse(data[1])));
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    return;
                }
            }

            string command;

            while ((command = Console.ReadLine()) != "END")
            {
                var data = command.Split();

                string personName = data[0];
                string productName = data[1];

                var person = persons.Single(p => p.Name == personName);
                var product = products.Single(p => p.Name == productName);

                if (!person.BuyProduct(product))
                {
                    Console.WriteLine($"{person.Name} can't afford {product.Name}");
                }
                else
                {
                    Console.WriteLine($"{person.Name} bought {product.Name}");
                }
            }

            foreach (var person in persons)
            {
                string productsBought;
                if (person.Products.Count == 0)
                {
                    productsBought = "Nothing bought";
                }
                else
                {
                    productsBought = ", " + person.Products.Select(p => p.Name);                    
                }
                Console.WriteLine($"{person.Name} - {productsBought}");
            }
            Console.ReadKey();
        }
    }
}
