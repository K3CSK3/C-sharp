Random rnd = new Random();
int evenNumber;
int oddNumber;
bool isNumber;
int random;
double average;
int canBeSharedWith4 = 0;

do
{
    Console.Write("Please type an odd number: ");
     string input = Console.ReadLine();

    isNumber = int.TryParse(input, out oddNumber );

}
while ( !isNumber || oddNumber % 2 != 0);

do
{
    Console.Write("Please type an even number smaller than the event number: ");
    string input = Console.ReadLine();

    isNumber = int.TryParse(input, out evenNumber);

}
while (!isNumber || oddNumber % 2 == 0 || oddNumber < evenNumber);

random = rnd.Next(evenNumber, oddNumber);

if((random - evenNumber) > (oddNumber - random))
{
    Console.WriteLine($"{random} is further form the odd numbers.");
}
else if((random - evenNumber) < (oddNumber - random))
{
    Console.WriteLine($"A {random} is further form the even numbers");
}
else
{
    Console.WriteLine("The random number is perfectly between.");
}

average = (double)(oddNumber + evenNumber) / 2;

for (int i = evenNumber; i < oddNumber; i++)
{
    if (i % 4 == 0)
    {
        canBeSharedWith4++;
    }
}

Console.WriteLine($"The average of the 2 numbers is: {average}\nBetween the 2 numbers there are {canBeSharedWith4} numbers divisible by 4");