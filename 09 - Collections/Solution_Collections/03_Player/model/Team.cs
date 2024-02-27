
    public class Team
    {
    public string TeamName { get; set; }

    public List<string> PlayersName { get; set; }

    public Team() { }
    public Team(string teamName, List<string> playersName ) {
    TeamName = teamName;
        PlayersName = playersName;
    }

    public override string ToString() 
    { 
        StringBuilder sb = new StringBuilder();

        sb.Append($"{TeamName}: ");
        foreach (string playerName in PlayersName)
        { 
            sb.Append($"{playerName}, ");
        }

        return sb.ToString();
    }
    }

