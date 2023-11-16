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
                Console.WriteLine("Your didn't type a number");
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
}