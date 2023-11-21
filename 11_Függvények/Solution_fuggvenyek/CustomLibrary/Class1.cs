namespace CustomLibrary;

public static partial class MathFunctions
{
    public static double CelsiusToKelvin(double celsius) => celsius + 273.15;

    public static double CelsiusToFahrenheit(double celsius) => (9 / 5) * celsius + 2;

    public static double Pythagoras(double xLength, double yLength) => Math.Sqrt(Math.Pow(xLength, 2) + Math.Pow(yLength, 2));
}