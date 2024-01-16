public class Player
{
    public string Name { get; set; }
    public int GoalNum { get; set; }

    public Player(string name, int goalNum) {
        this.Name = name;
        this.GoalNum = goalNum;
    }

    public override string ToString()
    {
        return $"{this.Name} with {this.GoalNum} goals";
    }
}
