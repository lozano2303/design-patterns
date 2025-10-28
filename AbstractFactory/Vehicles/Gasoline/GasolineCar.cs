using System;
using AbstractFactory.Vehicles.Interfaces;

namespace AbstractFactory.Vehicles.Gasoline
{
    public class GasolineCar : ICar
    {
        public void Drive()
        {
            Console.WriteLine("Conduciendo un auto a gasolina, hace muucho ruido!");
        }
    }
}