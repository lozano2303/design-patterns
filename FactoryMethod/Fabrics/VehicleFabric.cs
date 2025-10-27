using FactoryMethod.Products;

namespace FactoryMethod.Fabrics
{
    public abstract class VehicleFabric
    {
        public abstract IVehicle Create();
    }
}