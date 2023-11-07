Console.Write("Drinks available:\n1 - Coca Cola\n2 - Pepsi\n3 - Fanta\n4 - Sprite\nPlease enter the number of the chosen drink: ");
int number = int.Parse(Console.ReadLine());

string drink = number switch
{
    1 => "Coca Cola",
    2 => "Pepsi",
    3 => "Fanta",
    4 => "Sprite",
    _ => "Invalid choice",
};

Console.WriteLine(drink);
Console.ReadKey();