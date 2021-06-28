using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class Motorcycle : IVehicle
    {
        public Motorcycle()
        {

        }

        public void Drive()
        {
            Console.WriteLine("Building a new motorcycle!");
        }
    }
}
