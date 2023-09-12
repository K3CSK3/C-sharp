using System.Globalization;

Console.Write("Please type your name: ");
string name = Console.ReadLine();

Console.Write("Please type your height (in meters): ");
double height = double.Parse(Console.ReadLine(), new CultureInfo("en-EN"));

Console.Write($"{name} az ön magassága {height}m!");