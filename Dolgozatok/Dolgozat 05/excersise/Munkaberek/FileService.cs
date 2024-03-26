public static class FileService
{
    public static async Task<List<Employee>> LoadEmployeeAsync(string fileName)
    {
        List<Employee> employees = new List<Employee>();
        Employee employee = null;

        string path = Path.Combine("Source", fileName);

        FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.None, 128);
        StreamReader sr = new StreamReader(fs);

        while (!sr.EndOfStream)
        {
            employee = new Employee();
            employee.Name = await sr.ReadLineAsync();
            employee.Project = await sr.ReadLineAsync();
            employee.WeeklyWorkedHours = (await sr.ReadLineAsync())
                                                .Split(',')
                                                .Select(x => int.Parse(x))
                                                .ToList();

            employees.Add(employee);
            await sr.ReadLineAsync();
        }
        return employees;
    }
    public static async Task WriteWeeklySalaryAsync(string fileName, IEnumerable<Employee> employees)
    {
        Directory.CreateDirectory("Output");
        string path = Path.Combine("Output", fileName);

        FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None, 128);
        StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);

        foreach (var employee in employees)
        {
            await sw.WriteLineAsync($"{employee.Name} {employee.WeeklySalary} HUF");
        }
    }



}
