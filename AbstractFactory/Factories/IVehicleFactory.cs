using AbstractFactory.Vehicles.Interfaces;

namespace AbstractFactory.Factories
{
    public interface IVehicleFactory
    {
        ICar CreateCar();
        IMotorCicle CreateMotorCicle();
    }
}