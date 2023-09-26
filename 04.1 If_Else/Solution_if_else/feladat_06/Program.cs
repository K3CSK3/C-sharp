Console.Write("Please enter a number: ");
int number1 = int.Parse(Console.ReadLine());

Console.Write("Please enter another number: ");
int number2 = int.Parse(Console.ReadLine());

Console.Write("Please enter another number: ");
int number3 = int.Parse(Console.ReadLine());

if (number1 < number2 && number1 < number3 && number2 < number3)
{
    Console.WriteLine($"{number1}, {number2}, {number3}");
}
else if (number1 < number2 && number1 < number3 && number2 > number3)
{
    Console.WriteLine($"{number1}, {number3}, {number2}");
}
else if (number1 > number2 && number1 < number3 && number2 < number3)
{
    Console.WriteLine($"{number2}, {number1}, {number3}");
}
else if (number1 > number2 && number1 > number3 && number2 < number3)
{
    Console.WriteLine($"{number2}, {number3}, {number1}");
}
else if (number1 > number2 && number1 > number3 && number2 > number3)
{
    Console.WriteLine($"{number3}, {number2}, {number1}");
}
else if (number1 < number2 && number1 > number3 && number2 > number3)
{
    Console.WriteLine($"{number3}, {number1}, {number2}");
}
else
{
    Console.WriteLine($"{number1}, {number2}, {number3}");
}
Console.ReadKey();