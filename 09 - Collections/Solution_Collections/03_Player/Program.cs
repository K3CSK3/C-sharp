List<Player> players =await FileService.GetPlayersAsync("adatok.txt");


//1 - Írjuk ki a képernyőre az össz adatot
players.WriteCollectionToConsole();

//2 - Keressük ki az ütő játékosokat az utok.txt állömányba
List<Player> hittingPlayers = players.Where(x => x.Post == "ütő").ToList();
await FileService.WriteToFileAsync(hittingPlayers, "utok");

//3 - A csapattagok.txt állományba mentsük a csapatokat és a hozzájuk tartozó játékosokat a következő formában:
//  Telekom Baku: Yelizaveta Mammadova, Yekaterina Gamova,
List<Team> teamsWithPlayersName = players.GroupBy(x => x.Team)
                                         .Select(x => new Team
                                         {
                                             TeamName = x.Key,
                                             PlayersName = x.Select(x => x.Name).ToList()
                                         }).ToList();

await FileService.WriteToFileAsync(teamsWithPlayersName, "csapattagok");


//4 - Rendezzük a játékosokat magasság szerint növekvő sorrendbe és a magaslatok.txt állományba mentsük el.
List<Player> playersOrderedByHeight = players.OrderBy(p => p.Height).ToList();
await FileService.WriteToFileAsync(playersOrderedByHeight, "magaslatok");

//5 - Mutassuk be a nemzetisegek.txt állományba, hogy mely nemzetiségek képviseltetik magukat a röplabdavilágban mint játékosok és milyen számban.
List<Nationality> nationalitiesAndTheirPlayerCount = players.GroupBy(p => p.Nationality)
                                                            .Select(p => new Nationality 
                                                            {
                                                                Nationaily = p.Key,
                                                                NumberOfPlayers = p.Count()
                                                            }).ToList();
await FileService.WriteToFileAsync(nationalitiesAndTheirPlayerCount, "nemzetisegek");

//6 - atlagnalmagasabbak.txt állományba keressük azon játékosok nevét és magasságát akik magasabbak mint az „adatbázisban” szereplő játékosok átlagos magasságánál.
double averageHeight = players.Average(p => p.Height);
List<PlayerNameAndHeight> playerNameAndHeightsAboveAverageHeight = players.Where(p => p.Height > averageHeight)
                                                                          .Select(p => new PlayerNameAndHeight
                                                                          { 
                                                                            PlayerName = p.Name,
                                                                            Height = p.Height
                                                                          })
                                                                          .ToList();
await FileService.WriteToFileAsync(playerNameAndHeightsAboveAverageHeight, "atlagnalmagasabbak");
//7 - Állítsa növekvő sorrendbe a posztok szerint a játékosok ösz magasságát
List<PostWithHeigth> postWithHeigths = players.GroupBy(p => p.Post)
                                              .Select(p => new PostWithHeigth
                                              {
                                                  PostName = p.Key,
                                                  PlayersHeights = p.Select(p => p.Height).ToList()
                                              }).OrderBy(p => p.SumOfHeights)
                                              .ToList();
Console.WriteLine();
postWithHeigths.WriteCollectionToConsole();

//8 - Egy szöveges állományba, „alacsonyak.txt” keresse ki a játékosok átlagmagasságától alacsonyabb játékosokat. Az állomány tartalmazza a játékosok nevét, magasságát és hogy mennyivel alacsonyabbak az átlagnál, 2 tizedes pontossággal.
List<PlayerNameAndHeightWithDifferenceofTheAverage> playerNameAndHeightWithDifferenceofTheAverages = players.Where(p => p.Height < averageHeight)
                                                                                                             .Select(p => new PlayerNameAndHeightWithDifferenceofTheAverage
                                                                                                             {
                                                                                                                 PlayerName = p.Name,
                                                                                                                 Height = p.Height,
                                                                                                                 AverageHeight = averageHeight
                                                                                                             }).ToList();
await FileService.WriteToFileAsync(playerNameAndHeightWithDifferenceofTheAverages, "alacsonyak");
