using System;
using System.Collections.Generic;
using System.Text;

namespace L6._2_Book_Shop
{
    class GoldenEditionBook : Book
    {
        public GoldenEditionBook(string author, string title, decimal price)
    : base(author, title, price)
        {
        }

        public override decimal Price
        {
            get
            {
                return base.Price * 1.3m;
            }
        }
    }
}
