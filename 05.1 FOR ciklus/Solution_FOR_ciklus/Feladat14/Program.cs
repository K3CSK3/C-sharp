bool isNumber;
int start;
int end;
int sumof5 = 0;
int sumof7 = 0;

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
    if (i % 5 == 0)
    {
        sumof5 += i;
    }
    else if (i % 7 == 0)
    {
        sumof7 += i;
    }
}

if (sumof5 > sumof7)
{
    Console.WriteLine($"In the interval of {start}-{end} the sum of numbers divisible by 5 is larger");
}
else if (sumof5 < sumof7)
{
    Console.WriteLine($"In the interval of {start}-{end} the sum of numbers divisible by 7 is larger");
}
else
{
    Console.WriteLine($"In the interval of {start}-{end} the sum of numbers divisible by 7 or 5 are equal");
}