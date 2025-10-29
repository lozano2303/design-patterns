namespace Singleton
{
    public class ProductionRegister
    {
        private static ProductionRegister _instance;
        private int _totalVehicles;

        private ProductionRegister()
        {
            _totalVehicles = 0;
        }

        public static ProductionRegister GetInstance()
        {
            if (_instance == null)
                _instance = new ProductionRegister();

            return _instance;
        }

        public void RegisterVehicle(string vehicleType)
        {
            _totalVehicles++;
            Console.WriteLine($"Vehiculo registrado: {vehicleType}");
        }

        public void GetTotalVehicles()
        {
            Console.WriteLine($"Total de vehiculos producidos: {_totalVehicles}");
        }
    }
}