using System;
using PatternFactoryMethod.ConcreteCreator;
using PatternFactoryMethod.Creator;

namespace PatternFactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Factory Method ===");

            VehicleFactory vehicleFactory;

            vehicleFactory = new CarFactory();
            vehicleFactory.GetVehicle().Drive();

            vehicleFactory = new MotorcycleFactory();
            vehicleFactory.GetVehicle().Drive();
        }
    }
}