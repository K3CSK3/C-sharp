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
int largest = 0;

for (int i = 0; i < MATRIX_SIZE; i++)
{
    for (int j = 0; j < MATRIX_SIZE; j++)
    {
        if ((MATRIX_SIZE - i) < j)
        {
            if (matrix[i, j] > largest)
            {
                largest = matrix[i, j];
            }
        }
    }
}

Console.WriteLine($"Sum of other diagonal {largest}");