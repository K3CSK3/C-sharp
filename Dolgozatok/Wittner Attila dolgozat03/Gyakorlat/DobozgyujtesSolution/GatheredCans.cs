public class GatheredCans
{
    public string ClassName { get; set; }

    public int QuarterLiter { get; set; }
    public int ThirdLiter { get; set; }
    public int HalfLiter { get; set; }

    public int Points { get; }

    public GatheredCans(string className, int quarterLiterNumber, int thirdLiterNumber, int halfLiterNumber)
    {
        this.ClassName = className;

        this.QuarterLiter = quarterLiterNumber;
        this.ThirdLiter = thirdLiterNumber;
        this.HalfLiter = halfLiterNumber;

        this.Points = QuarterLiter + ThirdLiter * 2 + HalfLiter * 3;
    }

    public override string ToString()
    {
        return $"{ClassName}\t\t{QuarterLiter}\t\t{ThirdLiter * 2}\t\t{HalfLiter * 3}\t  {Points}";
    }

}
