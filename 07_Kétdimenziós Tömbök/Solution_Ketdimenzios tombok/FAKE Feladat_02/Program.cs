using IOLibrary;

Random rnd = new Random();

int matrixX = ExtendedConsole.ReadInteger("Please type the X dimension of the matrix: ", 0);
int matrixY = ExtendedConsole.ReadInteger("Please type the Y dimension of the matrix: ", 0);


int[,] matrix = new int[matrixY, matrixX];

for (int i = 0; i < matrixY; i++)
{
    for (int j = 0; j < matrixX; j++)
    {
        matrix[i, j] = rnd.Next(0, 100);
    }
}

for (int i = 0; i < matrixY; i++)
{
    for (int j = 0; j < matrixX; j++)
    {
        Console.Write($"{matrix[i, j].ToString().PadLeft(3, ' ')} ");
    }
    Console.WriteLine();
}