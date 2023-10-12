int number1 = 0;
int number2 = 0;
int stepRate = 0;
bool isNumber = false;
int difference;

while (!isNumber)
{
    Console.Write("Please type a number: ");
     string input = Console.ReadLine();

    isNumber = int.TryParse(input, out number1);
}
isNumber = false;
while (!isNumber || number2 < number1)
{
    Console.Write("Please type a number bigger than the last one: ");
    string input = Console.ReadLine();

    isNumber = int.TryParse(input, out number2);
}


difference = number2 - number1;
isNumber = false;
while (!isNumber || difference < stepRate)
{
    Console.Write("Please type a number smaller than the difference of the two numbers: ");
    string input = Console.ReadLine();

    isNumber = int.TryParse(input, out stepRate);
}


for  (int i = number2; i > number1 ; i-=stepRate)
{
    Console.Write($"{i}; ");
}