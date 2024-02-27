

    public class Nationality
    {
    public string Nationaily {  get; set; }

    public int NumberOfPlayers { get; set; }

    public Nationality() { }

    public Nationality(string nationality, int numberOfPlayers) {
        Nationaily = nationality;
        NumberOfPlayers = numberOfPlayers;
    }

    public override string ToString()
    {
        return $"{Nationaily}, {NumberOfPlayers} db játékos ";
    }
}

