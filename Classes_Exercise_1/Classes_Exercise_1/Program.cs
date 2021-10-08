using System;

namespace Classes_Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();

            myCar.Make = "Honda";
            myCar.Model = "Civic";
            myCar.Year = 2000;

            Console.WriteLine($"Year: {myCar.Year}");
            Console.WriteLine($"Make: {myCar.Make}");
            Console.WriteLine($"Model: {myCar.Model}");    
        }
    }
}
