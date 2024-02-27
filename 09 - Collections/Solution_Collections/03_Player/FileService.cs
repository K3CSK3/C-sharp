
    public static class FileService
    {
    #region input
    public static async Task<List<Player>> GetPlayersAsync(string filename)
    {
        List<Player> players = new List<Player>();
        Player player = null;
        string line = string.Empty;
        string[] data = null;

        string path = Path.Combine("source", filename);

        using FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.None, 128);
        using StreamReader sr = new StreamReader(fs,Encoding.UTF8);

        while (!sr.EndOfStream)
        { 
            line = await sr.ReadLineAsync();
            data = line.Split("\t");

            player = new Player();

            player.Name = data[0];
            player.Height =int.Parse( data[1]);
            player.Post = data[2];
            player.Nationality = data[3];
            player.Team = data[4];
            player.Country = data[5];

            players.Add(player);

        }

        return players;
    }
    #endregion

    #region output
    public static async Task WriteToFileAsync(ICollection<Player> players, string filename)
    {
        Directory.CreateDirectory("output");
        string path = Path.Combine("output", $"{filename}.txt");

        using FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None, 128);
        using StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);

        foreach (Player player in players)
        {
            await sw.WriteLineAsync($"{player}");
        }
    }
    public static async Task WriteToFileAsync(ICollection<Nationality> nationalities, string filename)
    {
        Directory.CreateDirectory("output");
        string path = Path.Combine("output", $"{filename}.txt");

        using FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None, 128);
        using StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);

        foreach (Nationality nationality in nationalities)
        {
            await sw.WriteLineAsync($"{nationality}");
        }
    }

    public static async Task WriteToFileAsync(ICollection<Team> teams, string filename)
    {
        Directory.CreateDirectory("output");
        string path = Path.Combine("output", $"{filename}.txt");

        using FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None, 128);
        using StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);

        foreach (Team team in teams)
        {
            await sw.WriteLineAsync($"{team}");
        }
    }
    public static async Task WriteToFileAsync(ICollection<PlayerNameAndHeight> players, string filename)
    {
        Directory.CreateDirectory("output");
        string path = Path.Combine("output", $"{filename}.txt");

        using FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None, 128);
        using StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);

        foreach (PlayerNameAndHeight player in players)
        {
            await sw.WriteLineAsync($"{player}");
        }
    }

    public static async Task WriteToFileAsync(ICollection<PlayerNameAndHeightWithDifferenceofTheAverage> players, string filename)
    {
        Directory.CreateDirectory("output");
        string path = Path.Combine("output", $"{filename}.txt");

        using FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None, 128);
        using StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);

        foreach (PlayerNameAndHeightWithDifferenceofTheAverage player in players)
        {
            await sw.WriteLineAsync($"{player}");
        }
    }


    #endregion
}

