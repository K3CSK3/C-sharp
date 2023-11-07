using System.Globalization;

int number;
int sum = 0;
int numOfInputs = 0;
bool isNumber;

do
{
    numOfInputs++;
    Console.WriteLine("Please type a number: ");
    string input = Console.ReadLine();

    isNumber = int.TryParse(input, new CultureInfo("en-US"), out number);

    sum += number;
    Console.WriteLine($"Currently the sum is {sum} in {numOfInputs} inputs");

    if (!isNumber)
    {
        Console.WriteLine("Input is not a number");
    }
} while (!isNumber || sum < 100);
