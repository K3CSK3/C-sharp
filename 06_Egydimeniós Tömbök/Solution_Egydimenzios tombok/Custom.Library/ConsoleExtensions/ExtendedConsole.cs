using System.Drawing;
using System.Globalization;
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

            if (!isNumber)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You didn't type a number");
                Console.ResetColor();
            }
        } while (!isNumber);

        return number;
    }

    public static double ReadDouble()
    {
        bool isNumber;
        double number;

        do
        {
            string text = Console.ReadLine().Replace(',','.');
            isNumber = double.TryParse(text,new CultureInfo("en-US"), out number);

            if (!isNumber)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You didn't type a floating point number!");
                Console.ResetColor();
            }
        } while (!isNumber);

        return number;
    }

    public static string ReadString()
    {
        string text;

        do
        {
            text = Console.ReadLine().Trim();

            if (string.IsNullOrWhiteSpace(text))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You didn't type anything!");
                Console.ResetColor();
            }
        }
        while (string.IsNullOrWhiteSpace(text));
        return text;
    }

    public static string ReadName()
    {
        string firstName;
        string lastName;

        do
        {
            Console.Write("First Name: ");
            firstName = Console.ReadLine().Trim();


            if (string.IsNullOrWhiteSpace(firstName) || firstName.Length < 2)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You didn't type your name!");
                Console.ResetColor();
            }
            else
            {
                break;
            }
        }
        while (true);

        do
        {
            Console.Write("Last Name: ");
            lastName = Console.ReadLine().Trim();

            if (string.IsNullOrWhiteSpace(lastName) || lastName.Length < 2)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You didn't type your name!");
                Console.ResetColor();
            }
            else
            {
                break;
            }
        }
        while (true);

        return ($"{firstName + " " + lastName}");
    }

    public static int GetAge()
    {
        int birthYear;
        int yearNow = DateTime.Now.Year;
        do
        {
            birthYear = ReadInteger();

            if (birthYear > yearNow)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You didn't type a correct year!");
                Console.ResetColor();
            }
        }
        while (birthYear >= yearNow);

        int age = yearNow - birthYear;
        return age;
    }

    public static Point ReadCoordinate()
    {
        Point coordinate = new Point();
        Console.WriteLine("X value: ");
        coordinate.X = ExtendedConsole.ReadInteger();

        Console.WriteLine("Y value: ");
        coordinate.Y = ExtendedConsole.ReadInteger();

        return coordinate;
    }



    public static int ReadInteger(string prompt, int minValue, int maxValue = int.MaxValue)
    {
        bool isNumber;
        int number;

        do
        {
            Console.WriteLine(prompt);
            string text = Console.ReadLine();
            isNumber = int.TryParse(text, out number);

            if (!isNumber)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You didn't type a number");
                Console.ResetColor();
            }
        } while (!isNumber && (number >= minValue && number <= maxValue));

        return number;
    }

    public static double ReadDouble(string prompt)
    {
        bool isNumber;
        double number;

        do
        {
            Console.WriteLine(prompt);
            string text = Console.ReadLine().Replace(',', '.');
            isNumber = double.TryParse(text, new CultureInfo("en-US"), out number);

            if (!isNumber)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You didn't type a floating point number!");
                Console.ResetColor();
            }
        } while (!isNumber);

        return number;
    }

    public static string ReadString(string prompt)
    {
        string text;

        do
        {
            Console.WriteLine(prompt);
            text = Console.ReadLine().Trim();

            if (string.IsNullOrWhiteSpace(text))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You didn't type anything!");
                Console.ResetColor();
            }
        }
        while (string.IsNullOrWhiteSpace(text));
        return text;
    }

    public static string ReadName(string prompt)
    {
        string name;

        do
        {
            Console.WriteLine(prompt);
            name = Console.ReadLine().Trim();


            if (string.IsNullOrWhiteSpace(name) || name.Length < 2)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You didn't type your name!");
                Console.ResetColor();
            }
            else
            {
                break;
            }
        }
        while (true);

        return name;
    }

    public static int GetAge(string prompt)
    {
        int birthYear;
        int yearNow = DateTime.Now.Year;
        do
        {
            Console.WriteLine(prompt);
            birthYear = ReadInteger();

            if (birthYear > yearNow)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You didn't type a correct year!");
                Console.ResetColor();
            }
        }
        while (birthYear >= yearNow);

        int age = yearNow - birthYear;
        return age;
    }

    public static Point ReadCoordinate(string prompt)
    {
        Console.WriteLine(prompt);

        Point coordinate = new Point();
        Console.WriteLine("X value: ");
        coordinate.X = ExtendedConsole.ReadInteger();

        Console.WriteLine("Y value: ");
        coordinate.Y = ExtendedConsole.ReadInteger();

        return coordinate;
    }
}