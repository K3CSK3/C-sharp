using IOLibrary;

Console.Write("Please type the width of your property(m): ");
double propertyWidth = ExtendedConsole.ReadDouble();

Console.Write("Please type the length of your property(m): ");
double propertyLength = ExtendedConsole.ReadDouble();

double propertyArea = propertyWidth * propertyLength;

double tax = propertyWidth < 20 && propertyLength < 30 ? CalculateTax(propertyArea) * 0.75 : CalculateTax(propertyArea);

Console.WriteLine($"The tax for your property is: {tax:F2}");

double CalculateTax(double area) => area * 1000;