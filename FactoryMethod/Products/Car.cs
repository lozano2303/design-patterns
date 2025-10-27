using System;

namespace FactoryMethod.Products
{
    public class Car : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Conduciendo carro, RUUUUUUUN!!");
        }
    }
}