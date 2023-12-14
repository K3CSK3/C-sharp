using IOLibrary;

Player[] players = GetPlayers();
Console.Clear();

Console.WriteLine("Players in the team :");
WritePlayerToConsole(players);

double averageAmountOfGoals = players.Average(x => x.GoalNum);

Console.WriteLine("\nPlayers completing below average :");
Player[] playersBelowAvarage = players.Where(player => player.GoalNum < averageAmountOfGoals).ToArray();
WritePlayerToConsole(playersBelowAvarage);

int playersAboveAverage = players.Count(x => x.GoalNum > averageAmountOfGoals);
Console.WriteLine($"{playersAboveAverage} players scored above average");

Player mvp = GetMostValuablePlayer(players);
Console.WriteLine($"\nThe MVP is: {mvp.Name} with {mvp.GoalNum} goals");

Player[] GetPlayers()
{
    Player[] players = new Player[9];

    for (int i = 0; i < 9; i++)
    {
        string name = ExtendedConsole.ReadName("Please type the name of the player: ");
        int goals = ExtendedConsole.ReadInteger($"Please type the amount of goals {name} scored: ");

        players[i] = new Player(goals, name);
    }

    return players;
}

void WritePlayerToConsole(Player[] expenses)
{
    foreach (var player in players)
    {
        Console.WriteLine(player);
    }

}

Player GetMostValuablePlayer(Player[] players)
{
    int mostPoints = players.Max(player => player.GoalNum);
    Player bestPlayer = players.First(player => player.GoalNum == mostPoints);

    return bestPlayer;
}