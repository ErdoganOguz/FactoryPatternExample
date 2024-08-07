using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExample.Vehicles
{
    public class Truck : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Truck is driving...");
        }

        public void Stop()
        {
            Console.WriteLine("Truck has stopped.");
        }

        public string GetInfo()
        {
            return "This is a truck.";
        }
    }
}
