using IOLibrary;

const int EMPLOYEE_NUMBER = 5;

Worker[] workers = GetWorkers();

Console.WriteLine("Workers:");
WriteWorkersToConsole(workers);


Console.WriteLine("Additional tax:");
WriteExtrasToConsole(workers);

Worker[] GetWorkers()
{
    Worker[] workers = new Worker[5];
    Worker worker = null;

    for (int i = 0; i < EMPLOYEE_NUMBER; i++)
    {
        Console.WriteLine("Please type your name");
        string name = ExtendedConsole.ReadName();

        workers[i] = new Worker(name);
    }

    return workers;
}

void WriteWorkersToConsole(Worker[] workers)
{
    foreach (Worker worker in workers)
    {
        Console.WriteLine(worker);
    }
}

void WriteExtrasToConsole(Worker[] workers)
{
    Console.WriteLine($"\t\tSZJA\t\tTB\t\tNyH");
    foreach (Worker worker in workers)
    {
        Console.WriteLine($"{worker.Name.PadLeft(8)}\t{worker.SZJA:F2}Ft\t{worker.TB:F2}Ft\t{worker.NyH:F2}Ft");
    }
}