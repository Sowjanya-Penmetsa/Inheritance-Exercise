using System;
using System.Collections.Generic;
using System.Text;

namespace Person_and_Child
{
    public class Person
    {
        private string name;
        private int age;
        public Person(string name, int age)

        {

            this.Name = name;

            this.Age = age;

        }
        public virtual string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Name must have more than 3 characters");
                }
                name = value;
            }
        }
        public virtual int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age must be positive!");
                }
                age = value;
            }
        }
        public override string ToString()

        {

            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append(String.Format("Name: {0}, Age: {1}",

            this.Name,

            this.Age));

            return stringBuilder.ToString();

        }


    }
}

