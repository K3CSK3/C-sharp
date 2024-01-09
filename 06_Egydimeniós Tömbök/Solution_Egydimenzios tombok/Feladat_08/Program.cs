using IOLibrary;

const int NUMBER_OF_CARS = 10;

Console.WriteLine("\nCar\'s tanking here:");
Driver[] drivers = GetDrivers();
WriteArrayToConsole(drivers);

Console.Clear();
Console.WriteLine("\nCar\'s tanking here over 40 liters:");
Driver[] fuelOver40Liter = drivers.Where(X => X.Gas > 40).ToArray();
WriteArrayToConsole(fuelOver40Liter);


double overallFuelTanked = drivers.Sum(x => x.Gas);
Console.WriteLine($"\nThe sum of all the fuel that was tanked this day is : {overallFuelTanked} liters");


double mostFuelTanked = drivers.Max(x => x.Gas);
Driver[] highestTankers = drivers.Where(x => x.Gas == mostFuelTanked).ToArray();
Console.WriteLine("Drivers who tanked the most:");
WriteArrayToConsole(highestTankers);


double leastFuelTanked = drivers.Min(x => x.Gas);
Driver[] lowestTankers = drivers.Where(x => x.Gas == leastFuelTanked).ToArray();
Console.WriteLine("Drivers who tanked the least:");
WriteArrayToConsole(lowestTankers);


Console.WriteLine("\nCar\'s tanking here under 30 liters:");
Driver[] fuelUnder30Liter = drivers.Where(X => X.Gas < 30).ToArray();
WriteArrayToConsole(fuelUnder30Liter);


bool tanked50Liters = drivers.Any(x => x.Gas == 50);
Console.WriteLine($"\nThere {(tanked50Liters ? "were" : "weren't")} drivers who tanked exactly 50 liters");



Driver[] GetDrivers()
{
    Driver[] drivers = new Driver[NUMBER_OF_CARS];

    for (int i = 0; i < NUMBER_OF_CARS; i++)
    {
        string licence = ExtendedConsole.ReadString("Please type the car's licence plate number: ");
        double gas = ExtendedConsole.ReadDouble("Please type the amount of fuel the car tanked (in liters): ", 1, 200);
        double price = gas * 612.6;

        Driver driver = new Driver(licence, gas, price);

        drivers[i] = driver;
    }
    return drivers;
}

void WriteArrayToConsole(Driver[] drivers)
{
    foreach (Driver driver in drivers)
    {
        Console.WriteLine(driver);
    }
}