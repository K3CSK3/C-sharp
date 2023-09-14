Console.Write("Please type a number: ");
int number1 = int.Parse(Console.ReadLine());

Console.Write("Please type another number: ");
int number2 = int.Parse(Console.ReadLine());

Console.Write("Please type a third number: ");
int number3 = int.Parse(Console.ReadLine());

Console.Write("Please type a fourth number: ");
int number4 = int.Parse(Console.ReadLine());


int result = (number1 + number2) / (number3 - number4);
Console.Write($"({number1} + {number2}) / ({number3} - {number4}) = {result}");