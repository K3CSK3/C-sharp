
    internal class Position
    {
    public int NumberOfPlayers { get; set; }

    public string NameOfPosition { get; set; }

    public Position() { }
    public Position(int number, string nameOfPosition) {
    NumberOfPlayers = number;
        NameOfPosition = nameOfPosition;
   }
    }

