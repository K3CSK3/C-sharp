bool isNumber;
int start;
int end;
int sum = 0;
int a = 1;
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
    sum += i * a;
    a *= -1;
}

Console.WriteLine($"By adding every first number and subtracting every second number in the interval of {start}-{end} we get {sum}");