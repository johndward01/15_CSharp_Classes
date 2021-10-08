using System;
using System.Collections.Generic;

namespace Classes_Demo
{
    public class Program
    {        
        // Field
        public string myField;

        // Property
        internal int MyProperty { get; set; }


        static void Main(string[] args)
        {
            House house1 = new House(); // Declaring an instance of type house
            house1.Bathrooms = 1;
            house1.Bedrooms = 1;
            house1.FloorLevels = 1;
            house1.CarGarageSize = 2;

            House house2 = new House()
            {
                Bedrooms = 1,
                Bathrooms = 1,
                CarGarageSize = 1,
                FloorLevels = 1
            };

            House house3 = new House(2,2,2,2);

        }

       

    }
}
