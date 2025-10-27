using System;
using FactoryMethod.Fabrics;
using FactoryMethod.Products;

namespace FactoryMethod
{
    class Programm
    {
        static void Main(string[] args)
        {
            VehicleFabric carfabric = new CarFabric();
            IVehicle car = carfabric.Create();
            car.Drive();

            VehicleFabric motofabric = new MotorCicleFabric();
            IVehicle moto = motofabric.Create();
            moto.Drive();

            Console.ReadKey();
        }
    }
}