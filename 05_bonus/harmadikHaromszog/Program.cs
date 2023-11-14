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


for (int i = -1; i <= stepAmount*2; i+=2)
{

    for (int j = i/2; j < stepAmount-1; j++)
    {
        Console.Write("   ");
    }


    for (int k = 1; k <= i; k++)
    {

        if (k < 10) {
            Console.Write($" {k} ");
        }
        else {
            Console.Write($"{k} ");
        }

    }
    Console.WriteLine();
}