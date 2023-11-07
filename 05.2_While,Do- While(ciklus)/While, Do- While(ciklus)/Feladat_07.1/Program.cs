int number1;
int number2;
int stepRate;
bool isNumber;
int difference;

do
{
    Console.Write("Please type a number: ");
     string input = Console.ReadLine();

    isNumber = int.TryParse(input, out number1);
}
while (!isNumber);

do
{
    Console.Write("Please type a number bigger than the last one: ");
    string input = Console.ReadLine();

    isNumber = int.TryParse(input, out number2);
}
while (!isNumber || number2 < number1);

difference = number2 - number1;

do
{
    Console.Write("Please type a number smaller than the difference of the two numbers: ");
    string input = Console.ReadLine();

    isNumber = int.TryParse(input, out stepRate);
}
while (!isNumber || difference < stepRate);

for  (int i = number2; i >= number1 ; i-=stepRate)
{
    Console.Write($"{i}; ");
}