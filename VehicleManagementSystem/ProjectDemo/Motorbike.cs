namespace ProjectDemo
{
    public class Motorbike : Vehicle
    {
        public bool HasABS { get; set; }

        public Motorbike(string brand, string model, int year, bool hasABS)
            : base(brand, model, year)
        {
            HasABS = hasABS;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"[Motorbike] {Brand} {Model} - Year: {Year}, ABS: {(HasABS ? "Yes" : "No")}");
        }
    }
}