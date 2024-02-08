using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;

List<Movie> LoadData()
{
    JsonSerializerOptions options = new JsonSerializerOptions
    {
        Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
        PropertyNameCaseInsensitive = true,
        WriteIndented = true,
    };

    options.Converters.Add(new DateFormatConverter());

    FileStream fs = new FileStream("./../../../data.json", FileMode.Open, FileAccess.Read, FileShare.None);
    StreamReader sr = new StreamReader(fs, Encoding.UTF8);

    string jsonData = sr.ReadToEnd();
    return JsonSerializer.Deserialize<List<Movie>>(jsonData, options);

}

void WriteToConsole(string text, ICollection<Movie> movies)
{
    Console.WriteLine(text);
    Console.WriteLine(string.Join('\n', movies));
}

void WriteSingleToConsole(string text, Movie movie)
{
    Console.WriteLine(text);
    Console.WriteLine(movie);
}


List<Movie> movies = LoadData();
WriteToConsole($"Data ({movies.Count})", movies);

// 1 - Hány film adatát dolgozzuk fel?
int numberOfFilms = movies.Count;

// 2 - Mekkora bevételt hoztak a filmek Amerikában?
long sumInUs = movies.Where(x => x.USGross.HasValue).Sum(x => x.USGross.Value) ;

Console.WriteLine($"Total US gross value: {sumInUs}");
// 3 - Mekkora bevételt hoztak a filmek Világszerte?
long sumEverywhere = movies.Where(x => x.WorldwideGross.HasValue).Sum(x => x.WorldwideGross.Value);

Console.WriteLine($"Total gross value: {sumEverywhere}");
// 4 - Hány film jelent meg az 1990-es években?
int filmsIn1990 = movies.Count(x => x.ReleaseDate.Year >= 1990 && x.ReleaseDate.Year <= 1999);

Console.WriteLine($"Movies made in the '90s: {filmsIn1990}");
// 5 - Hányan szavaztak összessen az IMDB-n?
long votedOnIMDB = movies.Where(x => x.IMDBVotes.HasValue).Sum(x => x.IMDBVotes.Value);

Console.WriteLine($"Number of people who voted on IMDB : {votedOnIMDB}");
// 6 - Hányan szavaztak átlagossan az IMDB-n?
double votedOnIMDBAverage = movies.Where(x => x.IMDBVotes.HasValue).Average(x => x.IMDBVotes.Value);

Console.WriteLine($"Average of people who voted on IMDB: {votedOnIMDBAverage:F2}");
// 7 - A filmek  világszerte átlagban mennyit hoztak a konyhára?
double averageEverywhere = movies.Where(x => x.WorldwideGross.HasValue).Average(x => x.WorldwideGross.Value);

Console.WriteLine($"Average gross value: {averageEverywhere:F2}");
// 8 - Hány filmet rendezett 'Christopher Nolan' ?
int christopherNolanDirected = movies.Where(x =>x.Director?.ToLower() == "christopher nolan").Count();


Console.WriteLine($"Christopher Nolan directed {christopherNolanDirected} movies");
// 9 - Melyik filmeket rendezte 'James Cameron'?
List<Movie> jamesCameronDirected = movies.Where(x =>x.Director?.ToLower() == "james cameron").ToList();


Console.WriteLine($"Christopher Nolan directed {jamesCameronDirected} movies");
// 10 - Keresse ki a 'Fantasy' kaland (Adventure) zsáner kategóriájjú filmeket.
List<Movie> fantasyMovies = movies.Where(x => x.MajorGenre?.ToLower() == "adventure" && x.CreativeType?.ToLower() == "fantasy").ToList();


WriteToConsole("ketske",fantasyMovies);
// 11 - Kik rendeztek akció (Action) filmeket és mikor?
List<ActionDirectorAndWhen> actionDirectorsAndWhen = movies
    .Where(x => x.MajorGenre?.ToLower() == "action")
    .Where(x => x.Director is not null)
    .GroupBy(x => x.Director)
    .Select(x => new ActionDirectorAndWhen
    {
        Name = x.Key,
        Times = x.Select(x => x.ReleaseDate).ToList()
    }).ToList();

// 12 - 'Paramount Pictures' horror filmjeinek cime?
List<string> paramountHorror = movies.Where(x => x.Distributor?.ToLower() == "paramount pictures" && x.MajorGenre?.ToLower() == "horror")
                                     .Select(x => x.Title)
                                     .ToList();


Console.WriteLine($"");
// 13 - Van-e olyan film melyet 'Tom Crusie' rendezett?



Console.WriteLine($"");
// 14 - A 'Little Miss Sunshine' filme mekkora össz bevételt hozott?



Console.WriteLine($"");
// 15 - Hány olyan film van amely az IMDB-n 6 feletti osztályzatot ért el és a 'Rotten Tomatoes'-n pedig legalább 25-t?



Console.WriteLine($"");
// 16 - 'Michael Bay' filmjei átlagban mekkora bevételt hoztak?



Console.WriteLine($"");
// 17 - Melyek azok a 'Michael Bay' a 'Walt Disney Pictures' által forgalmazott fimek melyek legalább 150min hosszúak.



Console.WriteLine($"");
// 18 - Listázza ki a forgalmazókat úgy, hogy mindegyik csak egyszer jelenjen meg!



Console.WriteLine($"");
// 19 - Rendezze a filmeket az 'IMDB Votes' szerint  növekvő sorrendbe.



Console.WriteLine($"");
// 20 - Rendezze a filmeket címük szerint csökkenő sorrendbe!



Console.WriteLine($"");
// 21 - Melyek azok a filmek melyek hossza meghaladja a 120 percet?



Console.WriteLine($"");
// 22 - Hány film jelent meg december hónapban?



Console.WriteLine($"");
// 23 - Egyes besorolásokban (Rating) hány film található?



Console.WriteLine($"");
// 24 - Keresse ki azokat a filmeket melyeket 'Ron Howard' rendezett a 2000 években, 'PG-13' bsorolású, lagalább 80 perc hosszú és az IMDB legalább 6.5 átlagot ért el.



Console.WriteLine($"");
// 25 - A 'Lionsgate' kiadónál kik rendeztek filmeket?



Console.WriteLine($"");
// 26 - Az 'Universal' forgalmazó átlagban mennyit kültött film forgatására?



Console.WriteLine($"");
// 27 - Az 'IMDB Votes' alapján melyek azok a filmek, melyeket többen értékeltek min 30 000-n?



Console.WriteLine($"");
// 28 - Az 'American Pie' című filmnek hány része van?



Console.WriteLine($"");
// 29 - Van-e olyan film melynek a címében szerepel a 'fantasy' szó és a zsánere 'Adventure'?



Console.WriteLine($"");
// 30 - Átlagban hányan szavaztak az IMDB-n?



Console.WriteLine($"");
// 31 - Kik rendeztek a 'Warner Bros.' forgalmazónál dráma filmeket 1970 és 1975 közt melyre az 'IMDB Votes' alapján többen szavaztak az átlagnál?



Console.WriteLine($"");
// 32 - Van e olyan film amely karácsony napján jelent meg?


Console.WriteLine($"");

// 33 - 'Spider-Man' című filmek USA-ban mekkora bevételt hoztak?



Console.WriteLine($"");
// 34 - Keresse ki  szuperhősös (Super Hero) filmek címeit.