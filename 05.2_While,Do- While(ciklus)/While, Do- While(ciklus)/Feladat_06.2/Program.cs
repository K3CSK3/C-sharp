using System.Globalization;

int age = 0;
bool isNumber = false;
string ageGroup = string.Empty;

while (!isNumber || age < 0 || age > 99)
{
    Console.Write("Please type your age (between 0 and 99): ");
    string input = Console.ReadLine();

    isNumber = int.TryParse(input, new CultureInfo("en-US"), out age);

    if (!isNumber)
    {
        Console.WriteLine("Input is not a number");
    }

    else if (age < 0 || age > 99)
    {
        Console.WriteLine("Input is not within the range");
    }

}

if (age >= 0 && age <= 6)
{
    ageGroup = "kid";
}

else if (age >= 7 && age <= 18)
{
    ageGroup = "schoolboy";
}

else if (age >= 19 && age <= 65)
{
    ageGroup = "worker";
}

else if (age > 65)
{
    ageGroup = "retired";
}

Console.WriteLine($"You belong into {ageGroup} age group");