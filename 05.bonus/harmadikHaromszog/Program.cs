int stepNumber;
bool Isnumber = false;
do
{
    Console.Write("Please type a step amount: ");
    string input = Console.ReadLine();

    Isnumber = int.TryParse(input, out stepNumber);
}
while (!Isnumber || stepNumber < 1);

Console.Clear();

for (int i = -1; i <= stepNumber*2; i+=2)
{
    for (int j = i/2; j < stepNumber-1; j++)
    {
        Console.Write("\t");
    }
    for (int k = 1; k <= i; k++)
    {
        
        Console.Write($"{k} \t");
    }
    Console.WriteLine();
}