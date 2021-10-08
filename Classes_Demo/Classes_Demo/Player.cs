using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_Demo
{
    public class Player
    {
        public Player()
        {

        }

        public Player(int age, int health, string name)
        {
            Age = age;
            Health = health;
            Name = name;
        }

        // Fields
        public int Age { get; set; }
        public int Health { get; set; }
        public string Name { get; set; }

        public string ShowStatus()
        {
            return $"Age: {Age}\n" +
                   $"Health: {Health}\n" +
                   $"Name: {Name}\n";
        }
        

    }
}
