namespace ProjectDemo
{
    public class Car : Vehicle
    {
        public int SeatCount { get; set; }

        public string Color { get; set; }

        public Car(string brand, string model, int year, int seatCount, string color)
            : base(brand, model, year)
        {
            SeatCount = seatCount;
            Color = color;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"[Car] {Brand} {Model} - Year: {Year}, Number Seat: {SeatCount}");
        }
    }
}