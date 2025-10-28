using System;
using AbstractFactory.Vehicles.Interfaces;

namespace AbstractFactory.Vehicles.Electric
{
    public class ElectricMotorCicle : IMotorCicle
    {
        public void Ride()
        {
            Console.WriteLine("Montando una motocicleta electrica, es muy silenciosa!");
        }
    }
}