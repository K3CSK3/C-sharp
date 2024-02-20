//Írjuk ki a képernyőre az össz adatot
using System.Linq;

List<Books> books = await FileService.ReadFromFileAsync("adatok.txt");
books.WriteCollectionToConsole();

//Keressük ki az informatika témajú könyveket és mentsük el őket az informatika.txt állömányba
List<Books> itBooks = books.Where(x => x.Topic == "informatika").ToList();
await FileService.WriteToFileAsync("informatika", itBooks);

//Az 1900.txt állományba mentsük el azokat a könyveket amelyek az 1900-as években íródtak
List<Books> booksFrom1900 = books.Where(x => x.PublishYear >= 1900 && x.PublishYear < 2000).ToList();
await FileService.WriteToFileAsync("1900", booksFrom1900);

//Rendezzük az adatokat a könyvek oldalainak száma szerint csökkenő sorrendbe és a sorbarakott.txt állományba mentsük el.
List<Books> orderedBooks = books.OrderByDescending(x => x.PageNumber).ToList();
await FileService.WriteToFileAsync("sorbarakott", orderedBooks);

/*„kategoriak.txt” állományba mentse el a könyveket téma szerint. Például:
Thriller:
-könnyv1
- könnyv2
Krimi:
-könnyv1
- könnyv2
*/

Dictionary<string, List<Books>> booksByTopic = books.GroupBy(x => x.Topic).ToDictionary(x => x.Key, x => x.ToList());
/*
List<string> data = new List<string>();
foreach (var item in booksByTopic)
{
    data.Add($"{item.Key}:");
    foreach (var book in item.Value)
    {
        data.Add($"- {book}");
    }
}
*/
FileService.WriteDictToFileAsync("kategoriak", booksByTopic);
