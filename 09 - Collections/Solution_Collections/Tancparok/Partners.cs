public class Partners
{
    public string Dance { get; set; }
    public string Female { get; set; }
    public string Male { get; set; }

    public Partners()
    {}

    public Partners(string dance, string female, string male )
    {
        Dance = dance;
        Female = female;
        Male = male;
    }

    public override string ToString()
    {
        return $"{Dance}\n{Female} : {Male}\n";
    }
}
