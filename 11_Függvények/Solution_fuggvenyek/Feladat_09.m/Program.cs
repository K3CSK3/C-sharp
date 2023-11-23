using IOLibrary;
const double USD = 0.8;
const double JPY = 0.75;
const double CHF = 0.55;

Console.Write("Kérem adja meg a pénzösszeget HUF-ban: "); 
int huf = ExtendedConsole.ReadInteger();
double eur = (double)huf / 400;
Currency currency = GetCurrency();

double convertedValue = currency switch
{
    Currency.USD => eur / USD,
    Currency.CHF => eur / CHF,
    Currency.JPY => eur / JPY,
};

Console.WriteLine($"{huf} HUF = {eur} EUR");
Console.WriteLine($"{huf} HUF = {convertedValue} {currency}");

Currency GetCurrency()
{
    bool isCurrency;
    Currency currency;

    do
    {
        Console.Write("Kérem adja meg a cél valutát (USD, CHF, JPY): ");
        string input = ExtendedConsole.ReadString();
        isCurrency = Enum.TryParse(input, true, out currency);

    } while (!isCurrency);

    return currency;
}