using IOLibrary;

Console.WriteLine("Please type your name");
string name = ExtendedConsole.ReadName();
Console.Write("Hello ");
SystemExtensions.ColoredText(name);
Console.Write("!");