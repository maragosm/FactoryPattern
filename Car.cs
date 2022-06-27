using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Pattern
{
    public class Car : IVehicle
    {
        public Car()
        {
            Console.WriteLine("Building a car...");
        }

        public void Drive()
        {
            Console.WriteLine("Driving a new car!");
        }
    }
}
