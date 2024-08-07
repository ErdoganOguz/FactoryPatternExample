using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExample.Vehicles
{
    public class Bike : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Bike is driving...");
        }

        public void Stop()
        {
            Console.WriteLine("Bike has stopped.");
        }

        public string GetInfo()
        {
            return "This is a bike.";
        }
    }
}
