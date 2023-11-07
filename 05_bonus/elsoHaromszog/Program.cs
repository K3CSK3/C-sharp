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

for (int i = 0; i <= stepNumber; i++)
{
    for (int j = 1; j <= i; j++)
    {
        if (j < 10)
        {
        Console.Write($" {j}  ");
        }
        else
        {
        Console.Write($"{j}  ");        
        }
    }
    Console.WriteLine();
}