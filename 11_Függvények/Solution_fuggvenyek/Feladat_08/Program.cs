using System.Drawing;
using IOLibrary;
using CustomLibrary;

Point coordA = ReadCoordinate();

Point coordB = ReadCoordinate();


int xLength = Math.Abs(coordA.X - coordB.X);

int yLength = Math.Abs(coordA.Y - coordB.Y);


double distance = MathFunctions.Pythagoras(xLength, yLength);

Console.WriteLine($"The distance between point A({coordA.X}:{coordA.Y}) and point B({coordB.X}:{coordB.Y}) is {distance}");

static Point ReadCoordinate()
{
    Point coordinate = new Point();
    Console.Write("X value: ");
    coordinate.X = ExtendedConsole.ReadInteger();

    Console.Write("Y value: ");
    coordinate.Y = ExtendedConsole.ReadInteger();

    return coordinate;
}