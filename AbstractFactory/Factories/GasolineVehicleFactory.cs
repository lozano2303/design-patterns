using AbstractFactory.Vehicles.Interfaces;
using AbstractFactory.Vehicles.Gasoline;

namespace AbstractFactory.Factories
{
    public class GasolineVehicleFactory : IVehicleFactory
    {
        public ICar CreateCar()
        {
            return new GasolineCar();
        }

        public IMotorCicle CreateMotorCicle()
        {
            return new GasolineMotorCicle();
        }
    }
}