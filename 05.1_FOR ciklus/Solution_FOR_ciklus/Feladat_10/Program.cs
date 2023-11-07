bool isNumber;
int start;
int end;
int sum = 0;
int product = 1;

do
{
    Console.WriteLine("Please type the a number: ");
    string input = Console.ReadLine();
    isNumber = int.TryParse(input, out start);
} while (!isNumber);

do
{
    Console.WriteLine("Please type a number larger than the previous: ");
    string input = Console.ReadLine();
    isNumber = int.TryParse(input, out end);
} while (!isNumber || end < start);

for (int i = start; i <= end; i++)
{
    sum += i;
    product *= i;
}
Console.WriteLine($"In the interval of {start}-{end} the sum of numbers is {sum} and their product is {product}");