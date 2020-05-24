using System;
using System.Collections.Generic;
using System.Text;

namespace Person_and_Child
{
    class Child:Person
    {
        public Child(string name, int age) : base(name, age)
        {

        }
        public override string Name
        {
            get
            {
                return base.Name;
            }
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Name must have more than 3 characters");
                }
                base.Name = value;
            }
        }
        public override int Age
        {
            get
            {
                return base.Age;
            }
            set
            {
                if (value > 15)
                {
                    throw new ArgumentException("Age must not be more than 15");
                }
                base.Age = value;
            }

        }
    }
}

