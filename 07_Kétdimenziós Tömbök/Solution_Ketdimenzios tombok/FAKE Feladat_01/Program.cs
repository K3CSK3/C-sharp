Random rnd = new Random();
int[,] matrix = new int[4, 3];

for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 3; j++)
    {
        matrix[i, j] = rnd.Next(0, 11);
    }
}

for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write($"{matrix[i,j]} ");
    }
    Console.WriteLine();
}