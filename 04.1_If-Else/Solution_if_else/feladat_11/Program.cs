Console.Write("Please enter a number: ");
int number = int.Parse(Console.ReadLine());

if(number % 2 == 0)
{
    Console.WriteLine("The number is even");
}
else
{
    Console.WriteLine("The number is odd");
}
if (number >= 0)
{
    Console.WriteLine("The number is positive");
}
else
{
    Console.WriteLine("The number is negative");
}
if (number % 5 == 0)
{
    Console.WriteLine("The number is divisble by 5(without a remainder)");
}
else
{
    Console.WriteLine("The number is NOT divisble by 5(without a remainder)");
}

Console.ReadKey();