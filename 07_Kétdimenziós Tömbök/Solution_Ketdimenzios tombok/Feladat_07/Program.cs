Random random = new Random();
const int ROW_NUM = 7;
const int COL_NUM = 4;

double[,] weatherData = GetData();

WriteToConsole(weatherData);

double[] averageRainAmount = OrderDailyAvg(weatherData);
Console.WriteLine("\n1. Feladat:");
WriteToConsole(averageRainAmount);

string leastRain = GetLeastRainyDay(weatherData);
string mostRain = GetRainiestDay(weatherData);
Console.WriteLine($"\n{leastRain} esett a legkevesebb, {bestDay} esett a legtöbb csapadék");

string dayWithTheLargestAmountOfMorningRain = GetRainiestMorning(weatherData);
Console.WriteLine($"\n{dayWithTheLargestAmountOfMorningRain} esett a legtöbb eső reggel");

string dayWithTheLargestAmountOfRain622 = GetRainiestFrom6To22(weatherData);
Console.WriteLine($"\n{dayWithTheLargestAmountOfRain622} esett a legtöbb eső 6 és 22 előtt");


double[,] GetData()
{
    double[,] results = new double[ROW_NUM, COL_NUM];
    int temp = 0;
    double result;

    for (int i = 0; i < ROW_NUM; i++)
    {
        for (int j = 0; j < COL_NUM; j++)
        {
            temp = random.Next(10, 100);
            result = random.Next(0, 5) + (double)temp / (double)100;
            result = int.Parse($"{result:F2}");
            results[i, j] = result;
            if (j == 3)
            {
                results[i, j] = (Math.Round(((results[i, 0] + results[i, 1] + results[i, 2]) / (double)3) * 100)) / 100;
            }
        }
    }

    return results;
}

void WriteToConsole(double[,] data)
{
    for (int i = 0; i < ROW_NUM; i++)
    {

        for (int j = 0; j < COL_NUM; j++)
        {
            Console.Write($"{data[i, j],-4} ");
        }
        Console.WriteLine($"\t{i + 1}. nap");
    }
}

double[] OrderDailyAvg(double[,] data)
{
    double[] results = new double[ROW_NUM];
    double temp = 0;
    for (int i = 0; i < ROW_NUM; i++)
    {
        results[i] = data[i, 3];
    }

    for (int i = 0; i < COL_NUM; i++)
    {
        for (int j = i + 1; j < ROW_NUM; j++)
        {
            if (results[i] > results[j])
            {
                temp = results[i];
                results[i] = results[j];
                results[j] = temp;
            }
        }
    }

    return results;
}

void WriteArray(double[] data)
{
    foreach (var item in data)
    {
        Console.WriteLine(item);
    }
}

string GetLeastRainyDay(double[,] data)
{
    string result = "";
    double temp = data[0, 0] + data[0, 1] + data[0, 2];

    for (int i = 0; i < ROW_NUM; i++)
    {
        if (data[i, 0] + data[i, 1] + data[i, 2] < temp)
        {
            temp = data[i, 0] + data[i, 1] + data[i, 2];
            result = $"{i + 1}. nap";
        }
    }
    return result;
}

string GetRainiestDay(double[,] data)
{
    string result = "";
    double temp = 0;

    for (int i = 0; i < ROW_NUM; i++)
    {
        if (data[i, 0] + data[i, 1] + data[i, 2] > temp)
        {
            temp = data[i, 0] + data[i, 1] + data[i, 2];
            result = $"{i + 1}. nap";
        }
    }
    return result;
}

string GetRainiestMorning(double[,] data)
{
    string result = "";
    double temp = 0;

    for (int i = 0; i < ROW_NUM; i++)
    {
        if (data[i, 0] > temp)
        {
            temp = data[i, 0];
            result = $"{i + 1}. nap";
        }
    }
    return result;
}

string GetRainiestFrom6To22(double[,] data)
{
    string result = "";
    double temp = 0;

    for (int i = 0; i < ROW_NUM; i++)
    {
        if (data[i, 1] + data[i, 2] > temp)
        {
            temp = data[i, 1] + data[i, 2];
            result = $"{i + 1}. nap";
        }
    }
    return result;
}