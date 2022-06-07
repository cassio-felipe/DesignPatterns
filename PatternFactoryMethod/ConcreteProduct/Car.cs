using System;
using PatternFactoryMethod.Product;

namespace PatternFactoryMethod.ConcreteProduct
{
    public class Car : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Drive a car!");
        }
    }
}