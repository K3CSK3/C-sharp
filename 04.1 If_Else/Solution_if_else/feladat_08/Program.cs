Console.Write("Please enter a number: ");
int number = int.Parse(Console.ReadLine());     

if(number % 4 == 0 && number % 6 == 0)
{
    Console.WriteLine("The number is divisible by 4 and 6.");
}
else
{
    Console.WriteLine("The number is NOT divisible by 4 and 6.");
}

Console.ReadKey();