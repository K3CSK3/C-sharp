int stepAmount;
bool Isnumber;
do
{
    Console.Write("Please type the step amount: ");
    string input = Console.ReadLine();

    Isnumber = int.TryParse(input, out stepAmount);
}
while (!Isnumber || stepAmount < 1);

Console.Clear();

for (int i = 0; i <= stepAmount; i++)
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