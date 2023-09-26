Console.Write("Please enter a number: ");
int number = int.Parse(Console.ReadLine()); 

if (number > 0)
{
    Console.WriteLine($"{number} is more, than 0.");
}

Console.ReadKey();