Console.Write("Please enter a number: ");
int number1 = int.Parse(Console.ReadLine());

Console.Write("Please enter another number: ");
int number2 = int.Parse(Console.ReadLine());

if (number1 > number2)
{
    Console.WriteLine($"{number1} is more");
}
else if (number1 < number2)
{
    Console.WriteLine($"{number2} is more");
}
else
{
    Console.WriteLine("The numbers are equal to each other.");
}
Console.ReadKey();