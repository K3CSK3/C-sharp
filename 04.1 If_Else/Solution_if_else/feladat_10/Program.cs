Console.Write("Please enter a number: ");
int number = int.Parse(Console.ReadLine()); 

if(number % 2 == 0 && number % 3 == 0)
{
    Console.WriteLine("ZIZI");
}
else if (number % 2 == 0)
{
    Console.WriteLine("BIZ");
}
else if (number % 3 == 0)
{
    Console.WriteLine("BAZ");
}
else
{
    Console.WriteLine("The numbert is NOT divisible by 3 or 2(without a remainder)");
}

Console.ReadKey();