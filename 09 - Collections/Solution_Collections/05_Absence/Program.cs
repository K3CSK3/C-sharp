using IOLibrary;

// 1.Tárolja el a fájlok tartalmát olyan adatszerkezetben, amivel a további feladatok megoldhatók!

List<Absence> absences = await FileService.GetAbsencesAsync("szeptember.csv");

// 2. Határozza meg, és írja ki a képernyőre, hogy a diákok összesen hány órát mulasztottak ebben a hónapban.

int totalHours = absences.Sum(x => x.Hours);

Console.WriteLine($"Összes mulasztott órák száma: {totalHours}");

// 3. Kérjen be a felhasználótól
// -egy napot 1 és 30 között
// -egy tanuló nevét

Console.Write("Kérem adjon meg egy napot: ");
int day = int.Parse(Console.ReadLine());

Console.Write("Tanuló neve: ");
string name = Console.ReadLine();


/* 4. Írja ki a képernyőre, hogy az előző feladatban bekért tanulónak volt-e hiányzása! A „A
tanuló hiányzott szeptemberben” vagy „A tanuló nem hiányzott
szeptemberben” szöveget jelenítse meg*/

Console.WriteLine($"A tanuló {(absences.Any(x => x.Name == name)?"":"nem")} hiányzott szeptemberben");

/* 5. Írja ki a képernyőre azon tanulók nevét és osztályát a minta szerint, akik a 3. feladatban
bekért napon hiányoztak! (Ha a 3. feladatot nem tudta megoldani, akkor a 19-ei nappal
dolgozzon!) Ha nem volt hiányzó, akkor a „Nem volt hiányzó” szöveget jelenítse
meg!*/

List<Absence> absentOnDay = absences.Where(x => x.FirstDay <= day && x.LastDay >= day).ToList();

foreach (var student in absentOnDay)
{
    Console.WriteLine($"{student.Name}  ({student.Class})");
}

/* 6. Készítsen összesítést, amely osztályonként fájlba írja a mulasztott órák számát! Az
osszesites.csv nevű fájl tartalmazza az osztályt és a mulasztott órák számának
összegét!*/


StreamWriter sw = new StreamWriter("osszesites.csv");
sw.WriteLine("Osztály;Mulasztott órák száma");
var summary = absences.GroupBy(x => x.Class).Select(x => new { Class = x.Key, TotalHours = x.Sum(y => y.Hours) });
foreach (var item in summary)
{
    sw.WriteLine($"{item.Class};{item.TotalHours}");
}
sw.Close();

List<AbsenceByClass> absencesByClass = await FileService.GetAbsencesClassAsync("osszesites.csv");

foreach (var item in absencesByClass)
{
    Console.WriteLine($"{item.Class};{item.TotalHours}");
}