using IOLibrary;

const int NUMBER_OF_TRUCKS = 10;

Truck[] trucks = GetTrucks();

Console.Clear();

WriteArrayToConsole(trucks);

double sumOfWeight = trucks.Sum(x => x.Weight);
Console.WriteLine($"Summary of all weight: {sumOfWeight}");


double averageOfWeight = trucks.Average(x => x.Weight);
Console.WriteLine($"Average of all weight: {averageOfWeight}");


double mostWeight = trucks.Max(x => x.Weight);
Truck heaviestTruck = trucks.First(x => x.Weight == mostWeight);
Console.WriteLine($"Heaviest truck: {heaviestTruck}");


bool measured10T = trucks.Any(x => x.Weight == 10);
Console.WriteLine($"There {(measured10T?"were":"weren't")} any trucks measured to be 10 tonnes");


Truck[] moreThan10T = trucks.Where(x => x.Weight > 10).ToArray();
WriteLicense(moreThan10T);


int lightestTruckPlace = LightestTruckNum(trucks);
Console.WriteLine($"The lightest measured truck was the {lightestTruckPlace}. in the row");

Truck[] GetTrucks()
{
    Truck[] trucks = new Truck[NUMBER_OF_TRUCKS];

    for (int i = 0; i < NUMBER_OF_TRUCKS; i++)
    {
        string licensePlate = ExtendedConsole.ReadString("Please type the trucks license plate: ");
        double weightKg = new Random().Next(3500, 40000);

        trucks[i] = new Truck(licensePlate, weightKg / 1000);
    }
    return trucks;
}


int LightestTruckNum(Truck[] trucks)
{
    int counter = 0;
    double lightest = trucks.Min(x => x.Weight);
    foreach (Truck truck in trucks)
    {
        counter++;

        if (truck.Weight == lightest)
        {
            break;
        }
    }
    return counter;
}

void WriteLicense(Truck[] trucks)
{
    foreach(Truck truck in trucks)
    {
        Console.WriteLine($"{truck.LicensePlate}");
    }
}

void WriteArrayToConsole(object[] items) 
{
    foreach(object item in items)
    {
        Console.WriteLine(item.ToString());
    }
}