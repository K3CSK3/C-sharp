public static class FileService
{
    #region input
    public static async Task<List<Lottery>> GetLotteriesAsync(string filename)
    {
        List<Lottery> lotteries = new List<Lottery>();
        List<int> guesses = null;
        Lottery lottery = null;
        string line = string.Empty;
        string[] data = null;

        string path = Path.Combine("source", filename);

        using FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.None, 128);
        using StreamReader sr = new StreamReader(fs, Encoding.UTF8);

        while (!sr.EndOfStream)
        {
            line = await sr.ReadLineAsync();
            data = line.Split("\t");

            lottery = new Lottery();

            guesses = new List<int>();
            for (int i = 0; i < data[1].Split(",").Length-1; i++)
            {
                guesses.Add(int.Parse(data[1].Split(",")[i]));
            }

            lottery.Name = data[0];
            lottery.Guesses = guesses;

            lotteries.Add(lottery);

        }

        return lotteries;
    }
    #endregion

    #region output
    public static async Task WriteToFileAsync<T>(ICollection<T> items, string filename)
    {
        Directory.CreateDirectory("output");
        string path = Path.Combine("output", $"{filename}.txt");

        using FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None, 128);
        using StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);

        foreach (T item in items)
        {
            await sw.WriteLineAsync($"{item}");
        }
    }
    #endregion
}
