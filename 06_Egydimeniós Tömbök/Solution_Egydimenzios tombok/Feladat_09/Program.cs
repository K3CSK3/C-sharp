using IOLibrary;

const int NUMBER_OF_FRUITS = 3;

Fruit[] fruits = GetFruits();

double weightSum = fruits.Sum(x => x.Weight);
Console.WriteLine($"Total weight of fruits in storage: {weightSum}");

WriteIndividualPrice(fruits);

double storagePrice = fruits.Sum(x => x.Weight * x.Price);
Console.WriteLine($"The price of the whole storage is : {storagePrice}");

double topPrice = fruits.Max(x => x.Price);
Fruit mostExpensive = fruits.First(x => x.Price == topPrice);
Console.WriteLine($"The most expensive fruit is:\n{mostExpensive}");

double lightest = fruits.Min(x => x.Weight);
Fruit leastWeight = fruits.First(x => x.Weight == lightest);
Console.WriteLine($"The most expensive fruit is:\n{leastWeight}");

Fruit[] under100Kg = fruits.Where(x => x.Weight < 100).ToArray();
WriteArrayToConsole(under100Kg);

Fruit[] over1500Ft = fruits.Where(x => x.Price > 1500).ToArray();
WriteArrayToConsole(over1500Ft);

Fruit[] GetFruits() {
for (int i = 0; i < NUMBER_OF_FRUITS; i++) 
    {
        string name = ExtendedConsole.ReadString("Please type the fruits name: ");
        double weight = ExtendedConsole.ReadInteger("Please type the weight of the fruit: ", 1);
        double price = ExtendedConsole.ReadDouble("Please type the price (Ft/kg): ", 1);

        Fruit fruit = new Fruit(name, weight, price);

        fruits[i] = fruit;
    }
    return fruits;
}

void WriteIndividualPrice(Fruit[] fruits)
{
    foreach(Fruit fruit in fruits)
    {
        Console.WriteLine($"{fruit.Name} whole price is {fruit.Price * fruit.Weight} Ft");
    }
}

void WriteArrayToConsole(Fruit[] drivers)
{
    foreach (Fruit driver in drivers)
    {
        Console.WriteLine(driver);
    }
}