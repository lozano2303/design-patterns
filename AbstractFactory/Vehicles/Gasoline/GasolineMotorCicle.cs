using System;
using AbstractFactory.Vehicles.Interfaces;

namespace AbstractFactory.Vehicles.Gasoline
{
    public class GasolineMotorCicle : IMotorCicle
    {
        public void Ride()
        {
            Console.WriteLine("Conduciendo una motocicleta a gasolina, hace muuucho ruido!");
        }
    }
}