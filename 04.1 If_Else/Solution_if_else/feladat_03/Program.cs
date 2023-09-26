Console.Write("Please enter a number: ");
int number = int.Parse(Console.ReadLine());

if (number > -30 && number < 40)
{
    Console.WriteLine($"{number} is more than -30 and less than 40.");
}
else 
{
    Console.WriteLine("The number is not within the boundaries.");
}

Console.ReadKey();