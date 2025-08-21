namespace ProjectDemo
{
    public class Vehicle
    {
        public string? Brand { get; set; }

        public string? Model { get; set; }

        public int Year { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is Vehicle vehicle &&
                   Brand == vehicle.Brand &&
                   Model == vehicle.Model &&
                   Year == vehicle.Year;
        }

        public Vehicle()
        {
        }

        public Vehicle(string? brand, string? model, int year)
        {
            Brand = brand;
            Model = model;
            Year = year;
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"{Brand} {Model} - ({Year})");
        }
    }
}