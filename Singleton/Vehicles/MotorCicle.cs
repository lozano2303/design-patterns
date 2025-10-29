using Singleton;

namespace Singleton.Vehicles
{
    public class MotorCicle
    {
        public MotorCicle()
        {
            var RegisterVehicle = ProductionRegister.GetInstance();
            RegisterVehicle.RegisterVehicle("MotorCicle");
        }
    }
}