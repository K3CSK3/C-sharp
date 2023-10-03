string name = string.Empty;

do
{
    Console.Write("Please type your name: ");
    name = Console.ReadLine().Trim();
}
while (name.Length < 2);

Console.WriteLine("Hello " + name);