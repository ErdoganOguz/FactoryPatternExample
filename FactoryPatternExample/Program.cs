using FactoryPatternExample.Factories;
using FactoryPatternExample.Vehicles;
using System;

namespace FactoryPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            IVehicle car = VehicleFactory.CreateVehicle("car");
            car.Drive();
            Console.WriteLine(car.GetInfo());
            car.Stop();

            IVehicle bike = VehicleFactory.CreateVehicle("bike");
            bike.Drive();
            Console.WriteLine(bike.GetInfo());
            bike.Stop();

            IVehicle truck = VehicleFactory.CreateVehicle("truck");
            truck.Drive();
            Console.WriteLine(truck.GetInfo());
            truck.Stop();

            IVehicle otobüs = VehicleFactory.CreateVehicle("otobüs");
        }
    }
}
