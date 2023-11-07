bool isNumber;
int start;
int end;
int sum = 0;
double count = 0;
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
    count++;
    sum += i;
}

average = (double)sum/count;
Console.WriteLine($"The average of the interval {start}-{end} is {average}");