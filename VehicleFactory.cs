using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Pattern
{
    public static class VehicleFactory
    {
        public static IVehicle BuildVehicle(string tires)
        {
            switch (tires)
            {
                case "2":
                    return new Motorcycle();
                case "4":
                    return new Car();
                case "two":
                    return new Motorcycle();
                case "four":
                    return new Car();
                default:
                    return new Car();
            }
        }
    }
}
