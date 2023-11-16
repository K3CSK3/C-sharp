using IOLibrary;

Console.WriteLine("Please type your name");
string name = ExtendedConsole.ReadName();

Console.WriteLine("Please type the year of your birth: ");
int age = ExtendedConsole.GetAge();

Console.WriteLine($"{name} you are {age} years old this year.");