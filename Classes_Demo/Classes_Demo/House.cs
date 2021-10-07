using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_Demo
{   

    public class House
    {
        // Constructors        
        public House() // Default Constructor
        {

        }

        // Parameterized Constructor
        public House(int bedrooms, int bathrooms, int garage, int floors) 
        {
            Bedrooms = bedrooms;
            Bathrooms = bathrooms;
            CarGarageSize = garage;
            FloorLevels = floors;
        }

        // Fields
        public int someField;

        // Properties
        public int Bedrooms { get; set; }
        public int Bathrooms { get; set; }
        public int CarGarageSize { get; set; }
        public int FloorLevels { get; set; }

        // Methods
        public string Doorbell()
        {
            return "Ding dong";
        }
    }
}
