using System;

namespace Classes_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Before classes and Object-Oriented Programming was a thing, programmers used functional programming as a programming paradigm. 
            //Functional programming allows building a program using mathematical functions.

            /*A class can be thought of as a blueprint or a cookie cutter. A class describes an object, but it is not that object. 
             * An object is defined as a singular instance of a class or type. 
             * It is a block of memory that has been allocated on the heap, according to the blueprint.
             * Similar to real-life if you have a blueprint of a house, it is not an actual house, the blueprint only tells you how to build a house.
             * Moreover, if you create 2 houses from the same blueprint, they may seem the same but they are independent of each other. 
             * In the real world objects have describing factors such as color, speed, or weight; to name a few. 
             * In code, we create classes in order to group these things together. 
             * Classes have members sort of like how methods have variables; however, classes are not only limited to variables.*/


            // Examples of Class Members  https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/members

            // Fields 
            // Properties
            // Methods
            // Constructors

            //---------These are beyond the scope of this course. If you are interested, click the link above for more info-------------------------------
            // Events
            // Operators
            // Indexers
            // Finalizers
            // Nested Types

            //TODO --> Create a class called Dog
            //TODO --> give it 1 field, property, and method    (i.e.)
            // prop = string Name
            // field = public string furColor
            // method = public void Speak()

            //TODO --> give the prop and field a value using the 3 ways to initialize an object

            // 1st way
            // Dog dog1 = new Dog();
            // dog1.Name = "buddy";
            // dog1.furColor = "brown and white";

            // 2nd way
            // Dog dog2 = new Dog()
            // {
            //      Name = "jack",
            //      furColor = "black"
            // };

            // 3rd way (constructor)
            // Dog dog3 = new Dog("meadow", "blonde");



        }
    }
}
