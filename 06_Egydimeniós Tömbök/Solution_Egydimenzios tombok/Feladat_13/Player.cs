public class Player
{
    public string Name { get; set; }
    public int Height { get; set; }
    public int SumOfPoints { get; set; }

    public Player(string name, int height, int sumOfPoints)
    {
        this.Name = name;
        this.Height = height;
        this.SumOfPoints = sumOfPoints;
    }

    public override string ToString()
    {
        return $"Player {this.Name}({this.Height}cm) scored {this.SumOfPoints} points this year.";
    }
}
