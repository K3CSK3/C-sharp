using System.Globalization;

internal static class ExtendedConsole
{
    public static int ReadNumber(string text)
    {
        bool isNumber;
        int number;
        do
        {
            Console.WriteLine(text);
            string input = Console.ReadLine();
            isNumber = int.TryParse(input, out number);
        } while (!isNumber || number <= 0);
        return number;
    }

    public static double ReadDouble(string text)
    {
        bool isNumber;
        double number;
        do
        {
            Console.WriteLine(text);
            string input = Console.ReadLine().Replace(",",".");
            isNumber = double.TryParse(input, new CultureInfo("EN-en"), out number);
        } while (!isNumber || number <= 0);
        return number;
    }
}
