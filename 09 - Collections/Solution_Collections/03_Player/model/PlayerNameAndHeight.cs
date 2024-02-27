
    public class PlayerNameAndHeight
    {
       public string PlayerName { get; set; }
    
    public int Height { get; set; }

    public PlayerNameAndHeight() { }
    public PlayerNameAndHeight(string playerName, int height) {
        PlayerName = playerName;
        Height = height;
    }

    public override string ToString()
    {
        return $"{PlayerName}, {Height} cm";
    }

}

