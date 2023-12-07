using System.Runtime.ExceptionServices;

Random rnd = new Random();

int[] array = await GetIntArrayAsync(10);

WriteIntArrayToConsole(array, "reverse");

int arraySum = GetArraySum(array);

Console.WriteLine($"Summary of the numbers this array is {arraySum}");

double average = (double)arraySum / array.Length;
Console.WriteLine($"The average of the numbers in the array is {average}");

int[] evenNumberArray = GetEvenNumbersInArray(array);
Console.WriteLine("Even numbers in the array:");
WriteIntArrayToConsole(evenNumberArray);

int doubleDigitNumbers = GetEvenDoubleDigitNumbersInArray(array);
Console.WriteLine($"There are {doubleDigitNumbers} double digit numbers in the array");

int[] singleDigitNumbers = GetSingleDigitNumbers(array);
Console.WriteLine($"Single digit numbers in array:");
WriteIntArrayToConsole(singleDigitNumbers);

int oddNumberSum = OddNumbersSum(array);
Console.WriteLine($"The sum of odd numbers in the array is: {oddNumberSum}");

int zeroEndNumbers = array.Count(x => x % 10 == 0);
Console.WriteLine($"There are {zeroEndNumbers} numbers ending in zero");

int[] orderedArray = ArrayOrderer(array);

async Task<int[]> GetIntArrayAsync(int arraySize)
{
    int[] array = new int[arraySize];

    for (int i = 0 ; i < arraySize; i++)
    {
        array[i] = rnd.Next(0, 100);
        await Task.Delay(100);
    }

    return array;
}

void WriteIntArrayToConsole(int[] array, string order="normal")
{
    if (order == "reverse")
    {
        for (int i = array.Length - 1; i >= 0; i--)
        {
            Console.WriteLine($"[{i+1}] = {array[i]}");
        }
    }
    else if (order == "normal")
    {
        for (int i = 0; i <= array.Length - 1; i++)
        {
            Console.WriteLine($"[{i + 1}] = {array[i]}");
        }
    }
}

int GetArraySum(int[] array) // => array.Sum(x => x)
{
    int sum = 0;

    foreach (int item in array)
    {
        sum += item;
    }

    return sum;
}

int[] GetEvenNumbersInArray(int[] array) => array.Where(x => x % 2 == 0).ToArray();

int GetEvenDoubleDigitNumbersInArray(int[] array) => array.Count( x => x > 9 && x < 100);

int[] GetSingleDigitNumbers(int[] array) => array.Where(x => x < 10).ToArray();

int OddNumbersSum(int[] array)
{
    int arraySum = 0;
    foreach (int item in array)
    {
        if (item % 2 == 1)
        {
            arraySum += 1;
        }
    }
    return arraySum;
}

void ArrayOrderer(int[] array, string order = "normal")
{
    int temp = 0;

    for (int i = 0; i < array.Length - 1; i++)
    {
        for (int j = 0; i < array.Length - 1; j++)
        {
            if (array[i] < array[j])
        }
    }
}