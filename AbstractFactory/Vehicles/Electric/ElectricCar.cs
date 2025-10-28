using System;
using AbstractFactory.Vehicles.Interfaces;

namespace AbstractFactory.Vehicles.Electric
{
    public class ElectricCar : ICar
    {
        public void Drive()
        {
            Console.WriteLine("Conduciendo un auto electrico, no hace mucho ruido!");
        }
    }
}