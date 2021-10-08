using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_Exercise_1
{
    class House
    {
        // Constructors
        public House()
        {

        }

        // Fields 
        public int numberOfWindows;

        // Properties
        public int Bedrooms { get; set; }
        public int Bathrooms { get; set; }

        // Methods
        public void WringDoorbell()
        {
            Console.WriteLine("Ding dong");
        }
    }
}
