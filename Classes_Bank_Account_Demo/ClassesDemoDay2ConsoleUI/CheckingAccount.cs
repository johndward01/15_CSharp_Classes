using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesDemoDay2ConsoleUI
{
    public class CheckingAccount
    {
        
        private decimal _balance; //Private Field

        public decimal Balance //Propfull (Full Property)
        {
            get { return _balance; }

            set
            {
                Console.WriteLine("Please enter your pin number");
                string pin = Console.ReadLine();
                if (pin == "1234")
                {
                    _balance = value;
                }
                else
                {
                    Console.WriteLine("Invalid user");
                    return;
                }
            }
        }

        public string AccountNumber { get; set; } //Auto prop

        //Field = local class variable
        private string _routingNumber;

        public string RoutingNumber //Propfull  (A full property)
        {
            get
            {
                return _routingNumber;
            }
            set
            {
                if (value.Length == 9)
                {
                    _routingNumber = value;
                }
                else
                {
                    Console.WriteLine("Invalid Routing Number");
                }
            }
        }

        public Customer Owner { get; set; } //Auto prop

        public void PrintBalance()
        {
            Console.WriteLine($"Your current balance is: {Balance}");
        }
    }
}
