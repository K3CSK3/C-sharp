Console.Write("Please enter a number: ");
int number = int.Parse(Console.ReadLine());

if (number >= 0)
{
    Console.WriteLine($"{number} is positive.");
}
else
{
    Console.WriteLine($"{number} is negative");
}

Console.ReadKey();
