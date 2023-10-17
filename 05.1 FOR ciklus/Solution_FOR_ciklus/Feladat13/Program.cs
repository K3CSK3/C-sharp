bool isNumber;
int start;
int end;
int sumOfEven = 0;
int sumOfOdd = 0;

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

if (sumOfEven > sumOfOdd)
{
    Console.WriteLine($"In the interval of {start}-{end} the sum of even numbers is larger");
}
else if (sumOfEven < sumOfOdd)
{
    Console.WriteLine($"In the interval of {start}-{end} the sum of odd numbers is larger");
}
else
{
    Console.WriteLine($"In the interval of {start}-{end} the sum of odd and even numbers are equal");
}