using IOLibrary;

const int NUMBER_OF_CARS = 2;

Driver[] drivers = GetDrivers();

WriteArrayToConsole(drivers);

int sumOfFines = drivers.Sum(driver => driver.Fine);
Console.WriteLine($"The summary of all fines is : {sumOfFines}");

Driver fastestDriver = GetFastestDriver(drivers);
Console.WriteLine($"The fastest car was: {fastestDriver.LicenceNumber} with a speed of {fastestDriver.Speed}");

int nonSpeedingDrivers = GetNonSpeedingDriversNumber(drivers);
double percentage = ((double)nonSpeedingDrivers /NUMBER_OF_CARS) * 100;
Console.WriteLine($"There were {nonSpeedingDrivers} drivers who didn't break the speed limit that is {percentage:F2}%");

bool driverAt60 = drivers.Any(driver => driver.Speed == 60);
Console.WriteLine($"There {(driverAt60 ? "were" : "weren't")} drivers who went with 60 km/h\" :");


Driver[] GetDrivers()
{
    Driver[] drivers = new Driver[NUMBER_OF_CARS];

    for (int i = 0; i < NUMBER_OF_CARS; i++)
    {
        string licence = ExtendedConsole.ReadString("Please type the car's licence plate number: ");
        int speed = ExtendedConsole.ReadInteger("Please type the car's speed: ", 1, 531);
        int fine = GetFine(speed);

        Driver driver = new Driver(licence, speed, fine);

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


int GetNonSpeedingDriversNumber(Driver[] drivers)
{
    int nonSpeeding = drivers.Count(nonSpeeding => nonSpeeding.Speed < 90);
    return nonSpeeding;
}

Driver GetFastestDriver(Driver[] drivers)
{
    int fastestSpeed = drivers.Max(driver => driver.Speed);
    Driver fastestCar = drivers.First(driver => driver.Speed == fastestSpeed);

    return fastestCar;
}

int GetFine(int speed)
{
    switch (speed)
    {
        case > 110:
            return 30000;
        case > 101:
            return 20000;
        case > 91:
            return 10000;
        default:
            return 0;
    }
}