using ProjectDemo;

namespace VehicleManagementSystem
{
    internal class Program
    {
        public static void Main(String[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>
            {
                new Car("Toyota", "Camry", 2022, 5, "red"),
                new Motorbike("Honda", "CBR500R", 2023, true),
                new Car("VinFast", "Lux A2.0", 2021, 5, "yellow"),
                new Motorbike("Yamaha", "Exciter", 2020, false)
            };

            foreach (var v in vehicles)
            {
                v.DisplayInfo();
            }

            Console.ReadLine();
        }
    }
}