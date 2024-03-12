public static class FileService
{
    #region input
    public static async Task<List<Absence>> GetAbsencesAsync(string filename)
    {
        List<Absence> absences = new List<Absence>();
        Absence absence = null;
        string line = string.Empty;
        string[] data = null;

        string path = Path.Combine("source", filename);

        using FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.None, 128);
        using StreamReader sr = new StreamReader(fs, Encoding.UTF8);

        await sr.ReadLineAsync();

        while (!sr.EndOfStream)
        {
            line = await sr.ReadLineAsync();
            data = line.Split(";");

            absence = new Absence();

            absence.Name = data[0];
            absence.Class = data[1];
            absence.FirstDay = int.Parse(data[2]);
            absence.LastDay = int.Parse(data[3]);
            absence.Hours = int.Parse(data[4]);

            absences.Add(absence);

        }

        return absences;
    }

    public static async Task<List<AbsenceByClass>> GetAbsencesClassAsync(string filename)
    {
        List<AbsenceByClass> absences = new List<AbsenceByClass>();
        AbsenceByClass absence = null;
        string line = string.Empty;
        string[] data = null;

        using FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.None, 128);
        using StreamReader sr = new StreamReader(fs, Encoding.UTF8);

        await sr.ReadLineAsync();

        while (!sr.EndOfStream)
        {
            line = await sr.ReadLineAsync();
            data = line.Split(";");

            absence = new AbsenceByClass();

            absence.Class = data[0];
            absence.TotalHours = int.Parse(data[1]);

            absences.Add(absence);

        }

        return absences;
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
