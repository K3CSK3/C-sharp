internal class Human
{
    public string Name;
    public int Age;
    public int Weight;
    public double? BenchpressAmount;
    public double? Strength;
    public string Rating;

    public override string ToString()
    {
        return $"{this.Name} is {this.Age} years old, they weigh {this.Weight}.\nThey can benchpress {this.BenchpressAmount} calculated strength is {this.Strength} why falls into the category of {this.Rating}";
    }
}
