using IOLibrary;
using CustomLibrary;

char conversionType;


Console.Write("Please give me a temperature in °C: ");
double baseTemperature = ExtendedConsole.ReadDouble();

do
{
    Console.Write("What do you want it to convert to K or °F (K/F) > ");
    conversionType = (Console.ReadKey().KeyChar);
} while (conversionType.ToString().ToUpper() != "K" && conversionType.ToString().ToUpper() != "F");

Console.Write($"\n{baseTemperature} °C equals");

if (conversionType.ToString().ToUpper() != "K")
{
    double convertedTemperature = MathFunctions.CelsiusToKelvin(baseTemperature);
    Console.Write($" {convertedTemperature} K");
}
else if (conversionType.ToString().ToUpper() != "F")
{
    double convertedTemperature = MathFunctions.CelsiusToKelvin(baseTemperature);
    Console.Write($" {convertedTemperature} °F");
}

