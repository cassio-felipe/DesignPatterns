using System;
using PatternFactoryMethod.Example1.ConcreteCreator;
using PatternFactoryMethod.Example1.Creator;

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