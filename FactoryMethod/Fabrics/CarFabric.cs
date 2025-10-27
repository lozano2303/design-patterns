using FactoryMethod.Products;

namespace FactoryMethod.Fabrics
{
    public class CarFabric : VehicleFabric
    {
        public override IVehicle Create()
        {
            return new Car();
        }
    }
}
