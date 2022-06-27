using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Pattern
{
    public class Motorcycle : IVehicle
    {
        public Motorcycle()
        {
            Console.WriteLine("Building a motorcycle...");
        }

        public void Drive()
        {
            Console.WriteLine("Driving a new motorcycle!");
        }
    }
}
