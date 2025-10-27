using FactoryMethod.Products;

namespace FactoryMethod.Fabrics
{
    public class MotorCicleFabric : VehicleFabric
    {
        public override IVehicle Create()
        {
            return new MotorCicle();
        }
    }
}