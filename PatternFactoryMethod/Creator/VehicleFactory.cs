using PatternFactoryMethod.Product;

namespace PatternFactoryMethod.Creator
{
    public abstract class VehicleFactory
    {
        public abstract IVehicle GetVehicle();
    }
}