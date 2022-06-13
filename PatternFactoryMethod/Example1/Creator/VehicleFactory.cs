using PatternFactoryMethod.Example1.Product;

namespace PatternFactoryMethod.Example1.Creator
{
    public abstract class VehicleFactory
    {
        public abstract IVehicle GetVehicle();
    }
}