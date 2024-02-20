public static class FileService
{
    #region FileRead
    public static async Task<List<Books>> ReadFromFileAsync(string fileName)
    {
        List<Books> books = new List<Books>();
        Books book = null;
        string line = string.Empty;
        string[] data = null;

        string path = Path.Combine("source", fileName);

        using FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.None);
        using StreamReader sr = new StreamReader(fs, Encoding.UTF8);

        await sr.ReadLineAsync();

        while (!sr.EndOfStream)
        {
            line = await sr.ReadLineAsync();
            data = line.Split("\t");
            await Console.Out.WriteLineAsync(line);

            book = new Books();
            book.WriterFirstName = data[0];
            book.WriterLastName = data[1];
            book.BirthDate = DateTime.Parse(data[2]);
            book.Title = data[3];
            book.ISBN = data[4];
            book.Publisher = data[5];
            book.PublishYear = int.Parse(data[6]);
            book.Price = int.Parse(data[7]);
            book.Topic = data[8];
            book.PageNumber = int.Parse(data[9]);
            book.Honorarium = int.Parse(data[10]);

            books.Add(book);
        }
        return books;
    }
    #endregion

    #region FileWrite
    public static async Task WriteToFileAsync(string fileName, ICollection<Books> books)
    {
        string path = Path.Combine("output", $"{fileName}.txt");
        List<string> data = new List<string>();

        foreach (Books book in books)
        {
            data.Add($"{book}");
        }

        await File.WriteAllLinesAsync(path, data);
    }
    public static async Task WriteDictToFileAsync(string fileName, Dictionary<string, List<Books>> books)
    {
        string path = Path.Combine("output", $"{fileName}.txt");
        foreach (Books book in books)
        {
            /**/
        }

        await File.WriteAllLinesAsync(path, data);
    }
    #endregion
}