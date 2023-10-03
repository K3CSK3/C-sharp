using System.Globalization;

int number = 0;
bool isNumber = false;

while (!isNumber || number < 0 || number > 9)
{
    Console.Write("Please type a number between 0 and 9: ");
    string input = Console.ReadLine();

    isNumber = int.TryParse(input, new CultureInfo("en-US"), out number);

    if (!isNumber)
    {
        Console.WriteLine("Input is not a number");
    }

    else if (number < 0 || number > 9)
    {
        Console.WriteLine("Input is not within the range");
    }

}
