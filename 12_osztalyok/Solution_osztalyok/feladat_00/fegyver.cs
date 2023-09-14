internal class Firearm
{
    public string Manufacturer { get; set; }

    public int YearOfProduction { get; set; }

    public string Model { get; set; }

    public int MagazineSize { get; set; }

    public string Caliber {get; set;}

    public override string ToString()
    {
        return ($"\n---------------------\nThe {this.Model} made by {this.Manufacturer} produced in {this.YearOfProduction}, holds {this.MagazineSize} amount of {this.Caliber} caliber bullets\n---------------------\n");
    }
}
