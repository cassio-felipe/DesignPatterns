using System;
using PatternFactoryMethod.Example1.Product;

namespace PatternFactoryMethod.Example1.ConcreteProduct
{
    public class Car : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Drive a car!");
        }
    }
}