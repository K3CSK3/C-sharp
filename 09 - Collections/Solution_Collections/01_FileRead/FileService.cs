public static class FileService
{

    #region FileReading
    public static async Task<List<Student>> ReadFromFileAsync(string fileName)
    {
        List<Student> students = new List<Student>();
        Student student = null;
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

            student = new Student();
            student.Name = data[0];
            student.Average = double.Parse(data[1]);

            students.Add(student);
        }

        return students;
    }

    public static async Task<List<Student>> ReadFromFileAsyncV2(string fileName)
    {
        List<Student> students = new List<Student>();
        Student student = null;
        string[] data = null;


        string path = Path.Combine("source", fileName);
        File.ReadAllLinesAsync(path, Encoding.UTF7);

        string[] lines = await File.ReadAllLinesAsync(path, Encoding.UTF7);

        foreach (string line in lines.Skip(1))
        {
            data = line.Split('\t');
            student = new Student();
            student.Name = data[0];
            student.Average = double.Parse(data[1]);

            students.Add(student);
        }

        return students;
    }

    public static async Task<List<Student>> ReadFromFileAsyncV3(string fileName)
    {
        List<Student> students = new List<Student>();
        Student student = null;
        string[] data = null;


        string path = Path.Combine("source", fileName);

        IAsyncEnumerable<string> lines = File.ReadLinesAsync(path, Encoding.UTF7);

        await foreach (string line in lines)
        {
            data = line.Split('\t');

            bool isNumber = double.TryParse(data[1], out double average);

            if (isNumber)
            {
                student = new Student();
                student.Name = data[0];
                student.Average = double.Parse(data[1]);

                students.Add(student);
            }
        }

        return students;
    }

    public static async Task<List<Student>> ReadFromFileAsyncV4(string fileName)
    {
        List<Student> students = new List<Student>();
        Student student = null;
        string[] data = null;


        string path = Path.Combine("source", fileName);

        string text = await File.ReadAllTextAsync(path, Encoding.UTF7);

        string[] lines = text.Split("\n");

        foreach (string line in lines.Skip(1)) //.Skip(1) átugorja az első sort, mert balfarok vagyo
        {
            data = line.Split('\t');
            student = new Student();
            student.Name = data[0];
            student.Average = double.Parse(data[1]);

            students.Add(student);
        }

        return students;
    }
    #endregion

    #region FileWrite
    public static async Task WriteToFileAsync(string fileName, ICollection<Student> students)
    {
        Directory.CreateDirectory("output");
        string path = Path.Combine("output", $"{fileName}.txt");

        using FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
        using StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);

        foreach (Student student in students)
        {
            await sw.WriteLineAsync($"{student.Name}\t{student.Average}");
        }
    }
    public static async Task WriteToFileAsyncV2(string fileName, ICollection<Student> students)
    {
        string path = Path.Combine("output", $"{fileName}.txt");
        List<string> data = new List<string>();

        foreach (Student student in students)
        {
            data.Add($"{student.Name}\t{student.Average}");
        }

        await File.WriteAllLinesAsync(path, data);
    }
    public static async Task WriteToFileAsyncV3(string fileName, ICollection<Student> students)
    {
        string path = Path.Combine("output", $"{fileName}.txt");

        StringBuilder contents = new StringBuilder();

        foreach (Student student in students)
        {
            contents.AppendLine($"{student.Name}\t{student.Average}");
        }

            
        await File.WriteAllTextAsync(path, contents.ToString(), Encoding.UTF8);
    }
    #endregion
}