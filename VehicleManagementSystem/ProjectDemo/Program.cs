using ProjectDemo;

namespace VehicleManagementSystem
{
    public partial class Program
    {
        public static int value = 100;

        public static void Main(String[] args)
        {
            //List<Vehicle> vehicles = new List<Vehicle>
            //{
            //    new Car("Toyota", "Camry", 2022, 5, "red"),
            //    new Motorbike("Honda", "CBR500R", 2023, true),
            //    new Car("VinFast", "Lux A2.0", 2021, 5, "yellow"),
            //    new Motorbike("Yamaha", "Exciter", 2020, false)
            //};

            //foreach (var v in vehicles)
            //{
            //    v.DisplayInfo();
            //}

            Vehicle vehicle1 = new Vehicle();

            Vehicle vehicle2 = new Vehicle();

            if (vehicle1.Equals(vehicle2))
            {
            }

            var list = new List<object>();
            list.Add("1");
            list.Add(1);

            Console.WriteLine(value);

            Console.ReadLine();
        }
    }
}

namespace Class2
{
    public partial class Program
    {
        //value = 1;
    }
}