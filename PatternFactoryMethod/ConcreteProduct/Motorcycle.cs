using System;
using PatternFactoryMethod.Product;

namespace PatternFactoryMethod.ConcreteProduct
{
    public class Motorcycle : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Drive a Motorcycle");
        }
    }
}