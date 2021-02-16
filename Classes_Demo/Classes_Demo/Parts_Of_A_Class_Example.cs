using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_Demo
{
    public class Parts_Of_A_Class_Example //we will discuss static more in a later lesson
    {
        //                                  ***** Required parts of a class ******
        // Access Modifier --> public, private, protected, internal, etc...
        // "class" Keyword  --> right before the name
        // Name  --> The name of the class
        // Scope --> {  }



        //                                  ***** Optional parts of a class ******
        //members are optional, however, why would you make an empty class 
        
        public int _field;

        public string Property { get; set; }

        public void Method()
        {
            Console.WriteLine("This is a Method");
        }
    }
}
