namespace IOLibrary;


public static class ExtendedConsole
{
    public static int ReadInteger()
    {
        bool isNumber;
        int number;

        do {
            string text = Console.ReadLine();
            isNumber = int.TryParse(text, out number);
        } while (!isNumber);

        return number;
    }

    public static double ReadDouble()
    {
        bool isNumber;
        double number;

        do
        {
            string text = Console.ReadLine();
            isNumber = double.TryParse(text, out number);
        } while (!isNumber);

        return number;
    }

}