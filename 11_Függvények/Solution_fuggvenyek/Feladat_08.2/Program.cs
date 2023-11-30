using IOLibrary;

Console.Write("Please type the width of your property(m): ");
double propertyWidth = ExtendedConsole.ReadDouble();

Console.Write("Please type the length of your property(m): ");
double propertyLength = ExtendedConsole.ReadDouble();

double propertyArea = propertyWidth * propertyLength;

double tax = propertyWidth < 20 && propertyLength < 30 ?
             CalculateTax(propertyArea, 25) :
             CalculateTax(propertyArea);

Console.WriteLine($"The tax for your property is: {tax:F2}Ft");

static double CalculateTax(double area, double discount = 0) => area * 1000 * ((100 - discount)/100);