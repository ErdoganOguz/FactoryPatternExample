using FactoryPatternExample.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExample.Factories
{
    public static class VehicleFactory
    {
        public static IVehicle CreateVehicle(string vehicleType)
        {
            switch (vehicleType.ToLower())
            {
                case "car":
                    return new Car();
                case "bike":
                    return new Bike();
                case "truck":
                    return new Truck();
                default:
                    throw new ArgumentException("Invalid vehicle type");
            }
        }
    }
}
