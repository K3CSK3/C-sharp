
Console.Write("Please type the year of release: ");
int releaseYear = int.Parse(Console.ReadLine());

Console.Write("Please type the director's name: ");
string directorsName = Console.ReadLine();

Console.Write("Please type the movies name: ");
string movieName = Console.ReadLine();

Console.Write("Please type the main actor's name: ");
string mainActorName = Console.ReadLine();

Console.WriteLine($"{releaseYear}-ban {directorsName} rendezésében megjelent a/az {movieName} című film {mainActorName} főszereplésével!");