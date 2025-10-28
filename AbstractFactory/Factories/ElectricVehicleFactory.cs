using AbstractFactory.Vehicles.Interfaces;
using AbstractFactory.Vehicles.Electric;

namespace AbstractFactory.Factories
{
    public class ElectricVehicleFactory : IVehicleFactory
    {
        public ICar CreateCar()
        {
            return new ElectricCar();
        }

        public IMotorCicle CreateMotorCicle()
        {
            return new ElectricMotorCicle();
        }
    }
}