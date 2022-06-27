using System;

namespace Factory_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many wheels will your vehicle have?");
            Console.Write("Tires: ");
            var userInput = Console.ReadLine();

            IVehicle vehicle1 = VehicleFactory.BuildVehicle(userInput);

            vehicle1.Drive();
        }
    }
}
