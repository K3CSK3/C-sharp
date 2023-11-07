Console.Write("Please enter a number: ");
int x = int.Parse(Console.ReadLine());

Console.Write("Please enter another number: ");
int y = int.Parse(Console.ReadLine());

if (x % y == 0 )
{
    Console.WriteLine("The second number can divide the first number(without a remainder)");
}
else
{
    Console.WriteLine("The second number can NOT divide the first number(without a remainder).");
}

Console.ReadKey();