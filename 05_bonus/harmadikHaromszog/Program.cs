int stepNumber;
bool Isnumber;
do
{
    Console.Write("Please type the step amount: ");
    string input = Console.ReadLine();

    Isnumber = int.TryParse(input, out stepNumber);
}
while (!Isnumber || stepNumber < 1);

Console.Clear();

for (int i = -1; i <= stepNumber*2; i+=2)
{
    for (int j = i/2; j < stepNumber-1; j++)
    {
        Console.Write("   ");
    }
    for (int k = 1; k <= i; k++)
    {
        if (k < 10)
        {
            Console.Write($" {k} ");
        }
        else
        {
            Console.Write($"{k} ");
        }

    }
    Console.WriteLine();
}