using PatternFactoryMethod.ConcreteProduct;
using PatternFactoryMethod.Creator;
using PatternFactoryMethod.Product;

namespace PatternFactoryMethod.ConcreteCreator
{
    public class MotorcycleFactory : VehicleFactory
    {
        public override IVehicle GetVehicle()
        {
            return new Motorcycle();
        }
    }
}