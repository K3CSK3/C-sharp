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

int sum = 0;

for (int i = 0; i < MATRIX_SIZE; i++)
{
    for (int j = 0; j < MATRIX_SIZE; j++)
    {
        if (j < i)
        {
            Console.Write(matrix[i, j].PadLeft(4, ' '));
        }
        else
        {
            Console.Write(" ".PadLeft(4, ' '));
        }
    }
}