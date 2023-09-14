Console.Write("Please type a number: ");
int number1 = int.Parse(Console.ReadLine());

Console.Write("Please type another number: ");
int number2 = int.Parse(Console.ReadLine());

Console.Write("Please type a third number: ");
int number3 = int.Parse(Console.ReadLine());

double result = ((double)(number1 * number2)) / number3;
Console.Write($"({number1} * {number2}) / {number3} = {result}");