public class TallSmall
{
    public Player Tallest { get; set; }
    public Player Smallest { get; set; }
    public int HeightDifference { get; }

    public TallSmall(Player tallest, Player smallest)
    {
        this.Tallest = tallest;
        this.Smallest = smallest;
        this.HeightDifference = tallest.Height - smallest.Height;
    }

    public override string ToString()
    {
        return $"\nA legmagassabb játékos {this.Tallest.Name}({this.Tallest.Height}cm).\nA legalacsonyabb játékos {this.Smallest.Name} ({this.Smallest.Height}cm).\nA különbség {this.HeightDifference}cm.";
    }
}
