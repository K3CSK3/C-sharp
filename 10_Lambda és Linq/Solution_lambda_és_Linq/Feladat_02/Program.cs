using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;


List<Game> games = new List<Game>();

void LoadData()
{
    using FileStream fs = new FileStream("./../../../data.json", FileMode.Open, FileAccess.Read, FileShare.None);
    using StreamReader sr = new StreamReader(fs, Encoding.UTF8);

    string jsonData = sr.ReadToEnd();
    games = JsonSerializer.Deserialize<List<Game>>(jsonData);
}

void WriteToConsole(string text, ICollection<Game> games)
{
    Console.WriteLine(text);
    Console.WriteLine(string.Join('\n', games));
}

void WriteSingleToConsole(string text, Game game)
{
    Console.WriteLine(text);
    Console.WriteLine(game);
}


LoadData();
WriteToConsole("Data", games);

/*
    Hány adat van a listában?
*/
int numberOfGames = games.Count;

/*
    Keressük ki azon játékokat, melyek MMORPG tipusuak (genre).
*/
List<Game> mmorpgs = games.Where(x => x.Genre == "MMORPG").ToList();

/*
Keressük ki azon játékokat, melyek 2013-ban jelentek meg.
*/
List<Game> releasedIn2013 = games.Where(x => DateTime.Parse(x.Release_date).Year == 2013).ToList();

/*
Keressük ki azon játékokat, melyek Darkflow Distribution KFR fejlesztett.
*/
List<Game> darkFlowMade = games.Where(x => x.Developer =="Darkflow Distribution KFR" ).ToList();

/*
Keressük ki hány shooter játék van a listában.
*/
int shooterGamesCount = games.Count(x => x.Genre.ToLower() == "shooter");

/*
Van-e olyan játék melyet Cryptic Studios fejleszett?
*/
List<Game> crypticStudioMade = games.Where(x => x.Developer == "Cryptic Studio").ToList();

/*
Keressük ki azon játékokat, melyek a címében (title) szerepel a ,,winter,, szó.
*/
List<Game> winterInTitle = games.Where(x => x.Title.Contains("winter")).ToList();

/*
Keressük ki a platformokat, de úgy, hogy mindegyik csak egyszer forduljon elő az eredménybe.
*/
List<string> platforms = games.Select(x => x.Platform).Distinct().ToList();

/*
Keressük ki , hogy típusonként (genre) hány játék van.
*/
List<GenreCount> genreCounts = games.GroupBy(x => x.Genre)
                                    .Select(x => new GenreCount
                                    {
                                        Genre = x.Key,
                                        Count = x.Count()
                                    })
                                    .ToList();

/*
Keressük ki az Electronic Arts álltal fejlesztett játékokat, melyek shooter típusúak.
*/
List<Game> shooterByEA = games.Where(x => x.Genre.ToLower() == "shooter" && x.Developer.ToLower() == "electronic arts").ToList();

/*
Keressük ki a listában szereplő fejlesztők  játékainak címét.
*/
List<GamesByDeveloper> gamesByDevelopers = games.GroupBy(x => x.Developer)
                                                       .Select(x => new GamesByDeveloper{
                                                           Developer = x.Key,
                                                           Games = x.Select(x => x.Title).ToList()
                                                        })
                                                       .ToList();

/*
Keressük ki azt a játékot mely legkorábban jelent meg.
*/
Game oldestGame = games.MinBy(x => DateTime.Parse(x.Release_date));


/*
Keressük ki azon játékok címét, melyeket az Ubisoft jelenített meg, 
a Blue Byte fejlesztett ki 2010 és 2015 közt.
*/
List<string> titlesMadeByUbiDevdByBluyByteBetween2010And2015XD = games.Where(y => y.Publisher.ToLower() == "ubisoft")
                                                                      .Where(y => y.Developer.ToLower() == "blue byte")
                                                                      .Where(y => DateTime.Parse(y.Release_date).Year >= 2010)
                                                                      .Where(y => DateTime.Parse(y.Release_date).Year <= 2015)
                                                                      .Select(y => y.Title)
                                                                      .ToList();
