using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Book_Shop_Inheritance
{
    public class Book
    {
        private string title;
        private string author;
        private decimal price;
        public Book(string author, string title, decimal price)

        {

            this.Author = author;

            this.Title = title;

            this.Price = price;

        }
        public virtual string Title
        {
            get
            {
                return title;
            }
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException(" Title not Valid");
                }
                title = value;
            }
        }
        public virtual string Author
        {
            get
            {
                return author;
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

                author = value;
            }
        }
        public virtual decimal Price
        {
            get
            {
                return price;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Invalid Price");
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
