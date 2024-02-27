public class Lottery
{
    public string Name { get; set; }
    public List<int> Guesses { get; set; } = new List<int>();

    public Lottery() { }

    public Lottery(string name, List<int> guesses)
    {
        Name = name;
        Guesses = guesses;
    }

    internal string GuessToString(List<int> guesses)
    {
        string guessToString = string.Empty;
        foreach (int guess in guesses)
            {
                guessToString += $"{guess},";
            }
        return guessToString;
    }

    public override string ToString()
    {
        return $"{Name}{(Name.ToLower().EndsWith('s')?"'":"'s")} numbers {GuessToString(Guesses)}";
    }
}
