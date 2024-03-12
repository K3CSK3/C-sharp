using System.Text;

public static class FileService
{
    #region input
    public static async Task<List<Partners>> GetPartnersAsync(string filename)
    {
        List<Partners> partners = new List<Partners>();
        Partners partner = null;
        

        string path = Path.Combine("source", filename);

        using FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.None, 128);
        using StreamReader sr = new StreamReader(fs, Encoding.UTF8);

        while (!sr.EndOfStream)
        {
            partner = new Partners(await sr.ReadLineAsync(), await sr.ReadLineAsync(), await sr.ReadLineAsync());
            partners.Add(partner);
        }

        return partners;
    }
    #endregion

    #region output
    public static async Task WriteToFileAsync<T>(ICollection<T> females, ICollection<T> males, string filename)
    {
        Directory.CreateDirectory("output");
        string path = Path.Combine("output", $"{filename}.txt");

        using FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None, 128);
        using StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);

        sw.WriteAsync("Lányok: ");
        foreach (T item in females.SkipLast(1))
        {
            await sw.WriteAsync($"{item}, ");
        }
        sw.WriteAsync($"{females.Last()}");

        sw.WriteAsync("\nFiúk: ");
        foreach (T item in males.SkipLast(1))
        {
            await sw.WriteAsync($"{item}, ");
        }
        sw.WriteAsync($"{males.Last()}");
    }
    #endregion
}
