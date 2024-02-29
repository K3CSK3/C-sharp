const int MATRIX_SIZE = 4;

int[,] matrix = new int[MATRIX_SIZE, MATRIX_SIZE];

for (int i = 0; i < MATRIX_SIZE; i++)
{
    for (int j = 0; j < MATRIX_SIZE; j++)
    {
        matrix[i, j] = (i + 1) * (j + 1);
    }
}

for (int i = 0; i < MATRIX_SIZE; i++)
{
    for (int j = 0; j < MATRIX_SIZE; j++)
    {
        Console.Write($"{matrix[i, j].ToString().PadLeft(4, ' ')}");
    }
    Console.WriteLine();
}

List<int> otherDiagonal = new List<int>();

for (int i = 0; i < MATRIX_SIZE; i++)
{
    for (int j = 0; j < MATRIX_SIZE; j++)
    {
        if ((i + j) == (MATRIX_SIZE - 1))
        {
            otherDiagonal.Add((i + 1) * (j + 1));
        }
    }
}

foreach (int number in otherDiagonal)
{
    Console.Write($"{number},");
}