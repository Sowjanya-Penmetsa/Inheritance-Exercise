using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Book_Shop_Inheritance
{
    public class GoldenEditionBook:Book
    {
        public GoldenEditionBook(string author, string title, decimal price) : base(author, title, price)
        {

        }
        public override string Title
        {
            get
            {
                return base.Title;
            }
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException(" Title not Valid");
                }
                base.Title = value;
            }
        }
        public override string Author
        {
            get
            {
                return base.Author;
            }
            set
            {
                foreach (char c in value)
                {
                    if (char.IsDigit(c))
                    {
                        throw new ArgumentException("Name cannot have digits ");
                    }
                }
                base.Author = value;
            }


        }
        public override decimal Price
        {
            get
            {
                                
                return base.Price * 3;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Invalid Price");
                }
                base.Price = value;
            }
        }
    }
}

