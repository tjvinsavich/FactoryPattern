using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public static class VehicleFactory
    {
        static VehicleFactory()
        {

        }

        public static IVehicle GetVehicle(int numTires)
        {
            switch (numTires)
            {
                case 4:
                    return new Car();
                case 2:
                    return new Motorcycle();
                default:
                    return new UnknownVehicle();
            }

        }
    }
}
