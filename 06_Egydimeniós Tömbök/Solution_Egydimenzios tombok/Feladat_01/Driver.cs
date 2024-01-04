public class Driver
{
    public string LicenceNumber { get; set; }
    public int Speed { get; set; }
    public int Fine { get; set; }

    public Driver(string licenceNumber, int speed, int fine)
    {
        this.LicenceNumber = licenceNumber;
        this.Speed = speed;
        this.Fine = fine;
    }

    public override string ToString()
    {
        return $"{this.LicenceNumber.ToString().PadLeft(7)} => {this.Speed.ToString().PadLeft(3)} = {this.Fine.ToString().PadLeft(5)}FT bírság";
    }
}
