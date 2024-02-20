List<Student> students = await FileService.ReadFromFileAsync("adatok.txt");

// 1 - Írjuk ki minden diák adatát a képernyőre!
students.WriteArrayToConsole();

// 2 - Hány diák jár az osztályba?
int classSize = students.Count();
Console.WriteLine($"{classSize} students are in the class");

// 3 - Mennyi az osztály átlaga?
double classAverage = students.Average(x => x.Average);
Console.WriteLine($"The average of the class is {classAverage:F2}");

// 4 - Keressük a legtöbb pontot elért érettségizőt és írjuk ki az adatait a képernyőre.
Student bestStudent = students.MaxBy(x => x.Average);
Console.WriteLine($"The best finishing student was {bestStudent}");

// 5 - atlagfelett.txt allományba keressük ki azon tanulókat kiknek pontjai meghaladják az átlagot!
List<Student> aboveAverage = students.Where(x => x.Average > classAverage).ToList();
await FileService.WriteToFileAsync("atlagfelett", aboveAverage);

// 6 - Van e kitünő tanulónk?
Console.WriteLine($"There {(students.Any(x => x.Average == 5) ? "were" : "weren't")} students with perfect grade");

/*7 - Hány elégtelen, elégséges, jó, jeles és kitünő tanuló van az osztályban?
	Értékhatárok:
	- elégtelen, ha: 0.00 - 1.99
	- elégséges, ha: 2.00 - 2.99
	- jó, ha: 3.00 - 3.99
	- jeles, ha: 4.00 - 4.99
	- kitünő, ha: 5.00
 */
Dictionary<string, int> sumOfRatings = DataService.GetSumOfRatings(students);
sumOfRatings.WriteCollectionToConsole();

/*
 Dictionary<Grade, int> gradesCount = new Dictionary<Grade, int>()
{
	[Grade.Elegtelen = student.Count(x=> x.Grade == Grade.Elegtelen)]
	[Grade.Elegseges = student.Count(x=> x.Grade == Grade.Elegseges)]
	[Grade.Kozepes = student.Count(x=> x.Grade == Grade.Kozepes)]
	[Grade.Jo = student.Count(x=> x.Grade == Grade.Jo)]
	[Grade.Jeles = student.Count(x=> x.Grade == Grade.Jeles)]
	[Grade.Kituno = student.Count(x=> x.Grade == Grade.Kituno)]
}
 */