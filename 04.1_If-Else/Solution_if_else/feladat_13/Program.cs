Console.Write("Please enter a number: ");
int number = int.Parse(Console.ReadLine());
number = Math.Abs(number);

if (number > 0 && number <=9)
{
    Console.WriteLine("The number is single digit.");
}
else if (number >= 10 && number <= 99)
{
    Console.WriteLine("The number is double digit.");
}
else
{
    Console.WriteLine("The number is triple digit.");
}

Console.ReadKey();