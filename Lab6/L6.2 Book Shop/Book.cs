using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace L6._2_Book_Shop
{
    class Book
    {
        private string title;
        private string author;
        private decimal price;

        public Book(string author, string title, decimal price)
        {
            Author = author;
            Title = title;
            Price = price;
        }

        public string Title
        {
            get
            {
                return title;
            }

            protected set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Title not valid!");
                }

                title = value;
            }
        }

        public string Author
        {
            get
            {
                return author;
            }

            protected set
            {
                if (Char.IsDigit(value[1]))
                {
                    throw new ArgumentException("Author not valid!");
                }

                author = value;
            }
        }

        public virtual decimal Price
        {
            get
            {
                return price;
            }

            protected set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Price not valid!");
                }

                price = value;
            }
        }

        public override string ToString()
        {
            var resultBuilder = new StringBuilder();
            resultBuilder.AppendLine($"Type: {this.GetType().Name}")
                .AppendLine($"Title: {this.Title}")
                .AppendLine($"Author: {this.Author}")
                .AppendLine($"Price: {this.Price:f2}");

            string result = resultBuilder.ToString().TrimEnd();
            return result;
        }
    }
}
