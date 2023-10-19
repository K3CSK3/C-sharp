bool isNumber;
int start;
int end;
int sumOfOdd = 0;
int sumOfEven = 0;
double average;

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
    if (i % 2 == 0)
    {
        sumOfEven += i;
    }
    else
    {
        sumOfOdd += i;
    }
}

average = (double)(sumOfOdd + sumOfEven)/2;
Console.WriteLine($"The average of the sum of odd numbers and sum of even numbers added together in the interval of {start}-{end} is {average}");