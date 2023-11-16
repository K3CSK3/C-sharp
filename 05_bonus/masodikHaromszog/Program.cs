int stepAmount;
bool isNum;


do
{
    Console.Write("Please type the step amount: ");
    string input = Console.ReadLine();

    isNum = int.TryParse(input, out stepAmount);
}
while (!isNum || stepAmount < 1);


Console.Clear();


for (int i = stepAmount; i >= 1; i--)
{
    for (int j = i; j >= 1; j--)
    {
        Console.Write($"{j}".PadRight(3, ' '));
    }
    Console.WriteLine();
}