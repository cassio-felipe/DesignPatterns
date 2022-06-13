using PatternFactoryMethod.Example1.ConcreteProduct;
using PatternFactoryMethod.Example1.Creator;
using PatternFactoryMethod.Example1.Product;

namespace PatternFactoryMethod.Example1.ConcreteCreator
{
    public class CarFactory : VehicleFactory
    {
        public override IVehicle GetVehicle()
        {
            return new Car();
        }
    }
}