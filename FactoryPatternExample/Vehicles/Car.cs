using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExample.Vehicles
{
    public class Car : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Car is driving...");
        }

        public void Stop()
        {
            Console.WriteLine("Car has stopped.");
        }

        public string GetInfo()
        {
            return "This is a car.";
        }
    }
}
