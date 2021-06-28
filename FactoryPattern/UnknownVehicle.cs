using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class UnknownVehicle : IVehicle
    {
        public UnknownVehicle()
        {
        }

        public void Drive()
        {
            Console.WriteLine("We don't know what vehicle you want!");
        }
    }
}
