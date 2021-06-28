using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many tires does your vehicle have?");

            int input;
            while(!int.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("Please enter a valid input.");
            }

            var vehicle = VehicleFactory.GetVehicle(input);

            vehicle.Drive();
        }
    }
}
