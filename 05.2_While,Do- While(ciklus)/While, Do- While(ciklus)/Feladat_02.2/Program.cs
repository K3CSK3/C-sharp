string name = string.Empty;

while (name.Length < 2)
{
    Console.Write("Please type your name: ");
    name = Console.ReadLine().Trim();
}

Console.WriteLine("Hello " + name);