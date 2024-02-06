namespace CustomLibrary;

public static partial class MathFunctions
{
    public static double CelsiusToKelvin(double celsius) => celsius + 273.15;

    public static double CelsiusToFahrenheit(double celsius) => (9 / 5 * celsius) + 32;
}

