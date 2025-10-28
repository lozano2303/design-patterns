using AbstractFactory.Vehicles.Interfaces;
using AbstractFactory.Factories;

namespace AbstractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("== Fabrica de vehiculos ==");

            IVehicleFactory gasolineFactory = new GasolineVehicleFactory();
            ICar gasolineCar = gasolineFactory.CreateCar();
            IMotorCicle gasolineMotorCicle = gasolineFactory.CreateMotorCicle();

            Console.WriteLine("\n-- Vehiculos a gasolina --");
            gasolineCar.Drive();
            gasolineMotorCicle.Ride();

            Console.WriteLine("\n------------------------\n");

            IVehicleFactory electricFactory = new ElectricVehicleFactory();
            ICar electricCar = electricFactory.CreateCar();
            IMotorCicle electricMotorCicle = electricFactory.CreateMotorCicle();

            Console.WriteLine("-- Vehiculos electricos --");
            electricCar.Drive();
            electricMotorCicle.Ride();
        }
    }
}