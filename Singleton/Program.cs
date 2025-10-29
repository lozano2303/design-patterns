using Singleton;
using Singleton.Vehicles;

Console.WriteLine("🏭 Iniciando producción de vehículos...");

Car car1 = new Car();
MotorCicle motorCicle1 = new MotorCicle();
Car car2 = new Car();

var register = ProductionRegister.GetInstance();
register.GetTotalVehicles();