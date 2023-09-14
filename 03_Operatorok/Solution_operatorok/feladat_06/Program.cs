Console.Write("Please type a number: ");
double number1 = double.Parse(Console.ReadLine());

Console.Write("Please type another number: ");
double number2 = double.Parse(Console.ReadLine());

Console.Write("Please type a third number: ");
int number3 = int.Parse(Console.ReadLine());


double remainder = ((number1 + 0.5) * (number2 - 0.7)) / number3;
Console.Write($"(({number1} + 0.5) * ({number2} - 0.7)) / {number3} the remainder is: {remainder}");