using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Classes_Demo
{
    class Dog
    {

        private string _name;
        public int age;
        public string breed;

        public Dog()
        {

        }

        public Dog(string name, int age, string breed)
        {
            name = name;
            age = age;
            breed = breed;
        }
        // Declare a property
        public string Name { get; set; }
        public int Age { get; set; }
        public string Breed { get; set; }

        // Create a method
        public void Speak()
        {
            Console.WriteLine("Woof");            
        }

       


    }
}
