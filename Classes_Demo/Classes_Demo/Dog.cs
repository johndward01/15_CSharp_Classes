using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_Demo
{
    public class Dog
    {
        public int Age { get; set; }
        public string Breed { get; set; }
        public string Name { get; set; }

        public void Speak()
        {
            Console.WriteLine($"{Name}");
        }


    }
}
