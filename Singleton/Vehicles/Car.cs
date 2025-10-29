using Singleton;

namespace Singleton.Vehicles
{
    public class Car
    {
        public Car()
        {
            var RegisterVehicle = ProductionRegister.GetInstance();
            RegisterVehicle.RegisterVehicle("Car");
        }
    }
}