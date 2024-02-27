//8 – A lotto.txt állományban az adatok a következő módón vannak tárolva:
//Név tippek

List<Lottery> lotteries = await FileService.GetLotteriesAsync("adatok.txt");

// - Írjuk ki a képernyőre az össz adatot
lotteries.WriteCollectionToConsole();

// - Random számok segítségével generáljuk le a napi 7 nyerő számot és írjuk őket egy szöveges állományba melynek az aktuális nap lesz a neve
List<int> winningNumbers = GenerateWinningNumbers();

await FileService.WriteToFileAsync(winningNumbers, DateTime.Now.DayOfWeek.ToString());

// - Keressük ki, van(ak)-e 7 találatos szelvény(ek), ha igen írjuk ki a nyertesek nevét a nyertesek-{mai dátum}.txt állományba.
List<string> winners = lotteries.Where(x => x.Guesses == winningNumbers).Select(x => x.Name).ToList();
await FileService.WriteToFileAsync(winners, DateTime.Now.ToString());

// -Keressük ki, hogy a befizetett játékosok hány találatot értek el, és mentsük el a talalatok-{mai dátum}.txt állományba a játékos nevét és a találatainak számát


// functions
List<int> GenerateWinningNumbers()
{
    Random rnd = new Random();
    List<int> winningNumbers = new List<int>();
    do
    {
        int number = rnd.Next(1, 46);
        if (!winningNumbers.Any(x => x == number))
        {
            winningNumbers.Add(number);
        }
    } while (winningNumbers.Count < 7);
    return winningNumbers;
}