using System;

namespace FactoryMethod.Products
{
    public class MotorCicle : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Conduciendo una moto, FIAAAAUUUM");
        }
    }
}