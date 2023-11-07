Console.Write("Please enter a number: ");
int x = int.Parse(Console.ReadLine());

Console.Write("Please enter another number: ");
int y = int.Parse(Console.ReadLine());

Console.Write("Please enter a third number: ");
int z = int.Parse(Console.ReadLine());

if (x % z ==0 && x % y == 0 )
{
    Console.WriteLine($"{x} is divisible by {z} and {y}.");
}
else if (x % y == 0)
{
    Console.WriteLine($"{x} is ONLY divisible by {y}.");
}
else if (x % z == 0)
{
    Console.WriteLine($"{x} is ONLY divisible by {z}.");
}    
else
{
    Console.WriteLine($"{x} is NOT divisible by any of the numbers.");
}

Console.ReadKey();