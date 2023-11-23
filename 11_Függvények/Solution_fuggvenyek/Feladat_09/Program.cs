using IOLibrary;

double convertedMoney;
string currencyType;
double baseMoney;

do
{
    Console.Write($"Please give the amount of HUF: ");
    baseMoney = ExtendedConsole.ReadDouble();
} while (baseMoney <= 0);

do
{
    Console.Write("What is the currency you are converting from (JPY, USD, CHF): ");
    currencyType = ExtendedConsole.ReadString().ToUpper();
} while (currencyType != "JPY" && currencyType != "USD" && currencyType != "CHF");

convertedMoney = baseMoney;

switch (currencyType)
{
    case "JPY":
        convertedMoney *= 0.427415;
        break;
    case "USD":
        convertedMoney *= 0.002867059;
        break;
    case "CHF":
        convertedMoney *= 0.002532183;
        break;
}


double convertedToEUR = SystemExtensions.ConvertToEUR(convertedMoney, currencyType);
Console.Write($"{baseMoney:F2} HUF is equal to {convertedMoney:F2} {currencyType} which is {convertedToEUR:F2} EUR\n\n");