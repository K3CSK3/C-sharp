Console.Write("Please enter a number: ");
int number1 = int.Parse(Console.ReadLine());

Console.Write("Please enter another number: ");
int number2 = int.Parse(Console.ReadLine());

Console.Write("Please enter a mathematical operations symbol: ");
string sign = Console.ReadLine();

double? result = sign switch
{
    "+" => number1 + number2,
    "-" => number1 - number2,
    "*" => number1 * number2,
    "/" => number1 / (double)number2,
    _ => null,
};
if( result == null)
{
    Console.WriteLine("No such mathematical operator");
}
else
{ 
    Console.WriteLine(result);
}

Console.ReadKey();