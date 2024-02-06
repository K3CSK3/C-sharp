
using System.Collections.Generic;

public class Team
{ 
    public string Name { get; set; }
    public List<string> PlayersName { get; set; }

    public Team() { }

    public Team(string teamName, List<string> playerName) { 
        Name = teamName;
        PlayersName = playerName;
    }
    }

