using System;

namespace Person_and_Child
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the name");
            string name = Console.ReadLine();
            Console.WriteLine("enter the age");
            int age = int.Parse(Console.ReadLine());

            try

            {
                Person person = new Person(name, age);
                //person.ToString();
                Console.WriteLine(person);
                Child child = new Child(name, age);
               // child.ToString();
                Console.WriteLine(child);

            }


            catch (ArgumentException ae)

            {
              Console.WriteLine(ae.Message);
            }
        }
    }
}
