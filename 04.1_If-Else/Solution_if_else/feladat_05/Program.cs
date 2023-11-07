Console.Write("Please enter a number: ");
int number1 = int.Parse(Console.ReadLine());

Console.Write("Please enter another number: ");
int number2 = int.Parse(Console.ReadLine());

if (number1 < number2)
{
    Console.WriteLine($"{number1}, {number2}");
}
else if (number1 > number2)
{
    Console.WriteLine($"{number2}, {number1}");
}
else
{
    Console.WriteLine($"{number1}, {number2}");
}
Console.ReadKey();