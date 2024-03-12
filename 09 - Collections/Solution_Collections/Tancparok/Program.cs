using System.Threading.Channels;

List<Partners> partners = await FileService.GetPartnersAsync("tancrend.txt");


Console.WriteLine($"Első Páros:\n{partners.First()}\n\nUtolsó Páros:\n{partners.Last()}");


int sambaCount = partners.Count(x => x.Dance == "samba");
Console.WriteLine($"{sambaCount} pár mutatta be a Samba-t\n");

Console.WriteLine("Vilma a következő táncokban szerepelt");
List<string> vilmaDances = partners.Where(x => x.Female == "Vilma").Distinct().Select(x => x.Dance).ToList();
vilmaDances.ForEach(x => Console.WriteLine(x));

Console.WriteLine();

List<string> dances = partners.Select(x => x.Dance).Distinct().ToList();
string danceToFind;

do
{
    Console.Write("Adja meg egy táncnak a nevét: ");
    danceToFind = Console.ReadLine();
    if (!dances.Contains(danceToFind.ToLower()))
    {
        Console.WriteLine("Nincs ilyen tánc!");
    }

} while (!dances.Contains(danceToFind.ToLower()));


Console.WriteLine((vilmaDances.Any(x => x == danceToFind) ?
    $"A {danceToFind} bemutatóján Vilma párja {partners.First(x => x.Dance == danceToFind).Male} volt." :
    $"Vilma nem táncolt {danceToFind}-t."));

List<string> females = partners.Select(x => x.Female).Distinct().ToList();
List<string> males = partners.Select(x => x.Male).Distinct().ToList();

await FileService.WriteToFileAsync(females, males, "szereplok");

Dictionary<string,int> malesAndCount =  males.ToDictionary(x => x, x => partners.Count(y => y.Male == x));
Dictionary<string, int> femalesAndCount = females.ToDictionary(x => x, x => partners.Count(y => y.Female == x));

int maleMax = malesAndCount.Max(x => x.Value);
int femaleMax = femalesAndCount.Max(x => x.Value);


List<string> mostParticipatingMales = GetMostParticipating(malesAndCount);
List<string> mostParticipatingFemales = GetMostParticipating(femalesAndCount);


Console.WriteLine();
mostParticipatingFemales.ForEach(x => Console.WriteLine($"{x} {femalesAndCount[x]}"));
Console.WriteLine();
mostParticipatingMales.ForEach(x => Console.WriteLine($"{x} {malesAndCount[x]}"));



List<string> GetMostParticipating(Dictionary<string, int> namesAndCount)
{
    List<string> mostParticipating = new List<string>();
    foreach (var item in namesAndCount)
    {
        if (item.Value == maleMax)
        {
            mostParticipating.Add(item.Key);
        }
    }
    return mostParticipating;
}