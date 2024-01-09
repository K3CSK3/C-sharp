public class Driver
{
    public string LicenceNumber { get; set; }
    public double Gas { get; set; }
    public double Cost { get; set; }

    public Driver(string licenceNumber, double gas, double cost)
    {
        this.LicenceNumber = licenceNumber;
        this.Gas = gas;
        this.Cost = cost;
    }

    public override string ToString()
    {
        return $"{this.LicenceNumber.ToString().PadLeft(7)} => {this.Gas.ToString().PadLeft(3)} L costing {this.Cost.ToString().PadLeft(5)} FT";
    }
}
