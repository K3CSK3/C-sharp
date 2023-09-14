Console.Write("Please type a number: ");
int number1 = int.Parse(Console.ReadLine());

Console.Write("Please type another number: ");
int number2 = int.Parse(Console.ReadLine());

int result = number1 + number2;
Console.Write($"{number1} + {number2} = {result}");