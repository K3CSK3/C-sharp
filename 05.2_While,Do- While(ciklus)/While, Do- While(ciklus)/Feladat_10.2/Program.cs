int number = 0;
bool isNumber = false;
int amount = 0;
int canBeSharedWith11 = 0;

do
{
    Console.Write("Please type a double digit number: ");
    string input = Console.ReadLine();

    isNumber = int.TryParse(input, out number);
}
while (!isNumber || (number < 1 || number > 99 ));

for  (int i = 0; i < number; i+=2)
{
    Console.Write($"{i}; ");
}
Console.WriteLine();
for  (int i = 0;i < number; i++)
{
    if(i % 5 == 0)
    {
        amount += i;
    }
    
    if(i % 11 == 0 )
    { 
        canBeSharedWith11++;
    }
    if(i % 7 == 3 )
    {
        Console.Write($"{i}; ");
    }
}

Console.WriteLine($"\nNumbers divisble by 5: {amount}\nNumbers divisible by 11: {canBeSharedWith11}");