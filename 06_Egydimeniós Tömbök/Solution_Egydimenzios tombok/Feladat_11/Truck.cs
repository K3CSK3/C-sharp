public class Truck
{
    public string LicensePlate { get; set; }
    public double Weight {get; set; }

    public Truck(string licensePlate, double weight)
    {
        this.LicensePlate = licensePlate;
        this.Weight = weight;
    }

    public override string ToString()
    {
        return $"Truck {this.LicensePlate} weighed {this.Weight} tonnes";
    }
}
