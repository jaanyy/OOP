using System;
using System.Collections.Generic;
using System.Text;

namespace _4_Shopping_Spree
{
    class Person
    {
        private string name;
        private decimal money;
        private List<Product> products;

        public Person(string name, decimal money)
        {
            Name = name;
            Money = money;
            products = new List<Product>();
        }

        public string Name
        {
            get
            {
                return name;
            }

            private set
            {
                if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }

                name = value;
            }
        }

        private decimal Money
        {
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }

                money = value;
            }
        }

        public List<Product> Products
        {
            get
            {
                return products;
            }
        }

        public bool BuyProduct(Product product)
        {
            if (money >= product.Cost)
            {
                money -= product.Cost;
                products.Add(product);
                return true;
            }

            return false;
        }
    }
}
