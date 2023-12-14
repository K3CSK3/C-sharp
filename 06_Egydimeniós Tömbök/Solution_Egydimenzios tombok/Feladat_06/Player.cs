public class Player
{
    public string Name { get; set; }

    public int GoalNum { get; set; }

    public Player(int goalNum, string name)
    {
        this.GoalNum = goalNum;
        this.Name = name;
    }

    public override string ToString()
    {
        return $"{this.Name.ToString().PadLeft(20)} => {this.GoalNum.ToString().PadLeft(4)} goals";
    }
}
