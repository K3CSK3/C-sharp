using IOLibrary;

Console.Write("Please type the width of the wall(m): ");
double wallWidth = ExtendedConsole.ReadDouble();

Console.Write("Please type the height of the wall(m): ");
double wallHeight = ExtendedConsole.ReadDouble();

double surfaceArea = wallWidth * wallHeight;

double amountOfPaint = surfaceArea * 0.15;

double costOfPaint = PaintCostCalculator(amountOfPaint);


Console.WriteLine($"The amount of paint is and {amountOfPaint:F2}L the cost will be: {costOfPaint:F2}");


double PaintCostCalculator(double amountOfPaint)
{
    return amountOfPaint * 930;
}