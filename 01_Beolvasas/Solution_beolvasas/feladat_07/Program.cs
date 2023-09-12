
Console.Write("Please type the brand's name: ");
string brand = Console.ReadLine();

Console.Write("Please type the brand's modell: ");
string modell = Console.ReadLine();

Console.Write("Please type the brand's type: ");
string type = Console.ReadLine();

Console.Write("Please type the brand's cubic centimeter: ");
int cubicCentimeter = int.Parse(Console.ReadLine());

Console.WriteLine($"Márka: {brand}\r\nModell: {modell}\r\nTípus: {type}\r\nKöbcenti: {cubicCentimeter}");