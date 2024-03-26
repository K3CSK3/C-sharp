List<Employee> employees = await FileService.LoadEmployeeAsync("munkaber.txt");

//2 - Milyen összeget kell kifizetni a munkabérekre, ha 10000 Ft/óra a munkabér?
int sumOfEmployeesWeeklyWorkedHours = employees.Sum(x => x.WeeklySalary);

Console.WriteLine($"Összesen {sumOfEmployeesWeeklyWorkedHours} HUF munkabért kell kifizetni.");

//3 - Ki dolgozta a héten a legtöbb órát?
Employee employeeWithMostWorkedHours = employees.MaxBy(x => x.SumOfWeeklyWorkedHours);

Console.WriteLine($"A héten a legtöbb munkaórát {employeeWithMostWorkedHours.Name} dolgozta ({employeeWithMostWorkedHours.SumOfWeeklyWorkedHours}óra).");

/*4 - -	Számítsuk ki a dolgozók fizetését, ha tudjuk, hogy 1 munkaóra az 10.000HUF
és a fizetes_2024-03.txt állományba mentsük (2024 a kifizetés éve, 03 a kifizetés hónapja) el a megadott minta szerint:
Hapci  360000 HUF).*/

string fileName = $"fizetes_{DateTime.Now:yyyy-MM}.txt";
await FileService.WriteWeeklySalaryAsync(fileName, employees);

/*5 - Keresse ki csoportba bontva a dolgozókat ledolgozott órák után. Három csoport létezik: rossz, átlagos és kiváló.
Rossznak az számít, aki nem érte el a heti 21 órát, átlagos az, aki 30 óráig teljesített
és a kiváló csoportba az tartozik, aki a héten 30 óra feletti óraszámmal rendelkezik.
Az eredményt a mintának megfelelően írja ki a képernyőre. (a minta csak reprezentatív, nem a valós eredményt mutathatja). */

Dictionary<Rating, IEnumerable<string>> ratedEmployees =
    employees.GroupBy(x => x.Rating)
                            .ToDictionary(
                                        x => x.Key,
                                        v => v.Select(s => $"{s.Name} ({s.SumOfWeeklyWorkedHours})"));

WriteRatedEmployeesToConsole(ratedEmployees);


/*6 - Melyik projecten dolgozókra kell a kifizetés hetén a legtöbb forrást biztosítani?
A mintában a 2024 az elszámolás éve, 03 az elszámolás hónapja és a 04 az elszámolás hónapjának a hete.
Az elszámolás hónap hetének meghatározására használhatja a megadott GetWeekNumberOfMonth függvényt!*/


string mostResourceIntensiveProject = employees.GroupBy(x => x.Project)
                                                .OrderByDescending(x => x.Sum(s => s.WeeklySalary))
                                                .First().Key;
Console.WriteLine(mostResourceIntensiveProject);

/*bonus - Ki/Kik és melyik nap dolgozta/dolgozták a legtöbb órát az elszámolás hetén? Az eredményt írja ki a képernyőre tetszőlegesen,
de tartalmaznia kell a dolgozó nevét, ledolgozott óráinak számát és a napot!*/

int maxWorkedHours = employees.Max(x => x.MostWorkedHours);
List<Employee> employeesWithMostWorkedHours = employees.Where(x => x.MostWorkedHours == maxWorkedHours).ToList();





int GetWeekNumberOfMonth(DateTime date)
{
    date = date.Date;
    DateTime firstMonthDay = new DateTime(date.Year, date.Month, 1);
    DateTime firstMonthMonday = firstMonthDay.AddDays((DayOfWeek.Monday + 7 - firstMonthDay.DayOfWeek) % 7);
    if (firstMonthMonday > date)
    {
        firstMonthDay = firstMonthDay.AddMonths(-1);
        firstMonthMonday = firstMonthDay.AddDays((DayOfWeek.Monday + 7 - firstMonthDay.DayOfWeek) % 7);
    }
    return (date - firstMonthMonday).Days / 7 + 1;
}

void WriteRatedEmployeesToConsole(Dictionary<Rating, IEnumerable<string>> ratedEmployees)
{
    foreach(KeyValuePair<Rating, IEnumerable<string>> ratedEmployee in ratedEmployees)
    {
        Console.WriteLine($"{ratedEmployee.Key}:");
        foreach (string employeeName in ratedEmployee.Value)
        {
            Console.WriteLine($"\t- {employeeName}");
        }
        Console.WriteLine();
    }
}