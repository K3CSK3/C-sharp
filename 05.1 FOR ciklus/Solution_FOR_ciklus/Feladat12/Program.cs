bool isNumber;
int start;
int end;
int count = 0;

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
    if (i % 3 == 0)
    {
        count++;
    }
}
Console.WriteLine($"In the interval of {start}-{end} there are {count} ");