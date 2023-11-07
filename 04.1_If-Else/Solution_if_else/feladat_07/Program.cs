Console.Write("Please enter a number: ");
int number = int.Parse(Console.ReadLine()); 

if(number % 5 == 0)
{
    Console.WriteLine("The number is divisible by 5");
}
else
{
    Console.WriteLine("The number is NOT divisible by 5");
}

Console.ReadKey();