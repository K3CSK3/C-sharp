Console.Write("Please enter a number: ");
int number = int.Parse(Console.ReadLine());

if((number > 10 && number < 20) || (number < -10 && number > -20) )
{
    Console.WriteLine("The number is within the set boundaries.");
}
else
{
    Console.WriteLine("The number is NOT within any of the set boundaries.");
}

Console.ReadKey();