using System;
using System.IO;

namespace Book_Shop_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                
                    Console.WriteLine("enter name of the author");
                    string author = Console.ReadLine();
                    Console.WriteLine("enter the title");
                    string title = Console.ReadLine();
                    Console.WriteLine("enter the price");
                    decimal price = decimal.Parse(Console.ReadLine());
                    Book book = new Book(author, title, price);
                    GoldenEditionBook goldenEditionBook = new GoldenEditionBook(author, title, price);
                    Console.WriteLine(book + Environment.NewLine);
                    Console.WriteLine(goldenEditionBook);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }



        }
    }
}
