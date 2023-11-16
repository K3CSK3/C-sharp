using IOLibrary;

Console.WriteLine("Please type a number");
int number1 = ExtendedConsole.ReadInteger();

Console.WriteLine("Please type another number");
int number2 = ExtendedConsole.ReadInteger();

int sum = SystemExtensions.Summary(number1, number2);
Console.WriteLine($"The sum of {number1} and {number2} is: {sum}");

int diff = SystemExtensions.Difference(number1, number2);
Console.WriteLine($"The difference of {number1} and {number2} is: {diff}");

int product = SystemExtensions.Product(number1, number2);
Console.WriteLine($"The product of {number1} and {number2} is: {product}");

double division = SystemExtensions.Division(number1, number2);
Console.WriteLine($"The division of {number1} and {number2} is: {division}");