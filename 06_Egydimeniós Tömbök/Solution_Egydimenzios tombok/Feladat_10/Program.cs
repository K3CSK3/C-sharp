using IOLibrary;

const int NUMBER_OF_PLAYERS = 5;

Player[] players = GetPlayers();

Console.Clear();

int sumOfPoints = players.Sum(x => x.GoalNum);
Console.WriteLine($"The team got {sumOfPoints} goals in total\n");

int mostPoints = players.Max(x => x.GoalNum);
Player bestPlayer = players.First(x => x.GoalNum == mostPoints);
Console.WriteLine($"The player who scored the most points is {bestPlayer}\n");

int leastPoints = players.Min(x => x.GoalNum);
Player worstPlayer = players.First(x => x.GoalNum == leastPoints);
Console.WriteLine($"The player who scored the least points is {worstPlayer}\n");

double averagePoints = players.Average(x => x.GoalNum);
int belowAverage = players.Count(x => x.GoalNum < averagePoints);
Console.WriteLine($"There were {belowAverage} players who scored below average\n");

Player[] aboveAverage = players.Where(x => x.GoalNum > averagePoints).ToArray();
Console.WriteLine("Players who scored goals above average:");
WriteArrayToConsole(aboveAverage);

Player[] GetPlayers()
{
    Player[] players = new Player[NUMBER_OF_PLAYERS];
    for (int i = 0; i < NUMBER_OF_PLAYERS; i++)
    {
        string name = ExtendedConsole.ReadString("Please type the player's name: ");
        int goals = ExtendedConsole.ReadInteger("Please type the amount of goals scored: ", 0, 200);

        players[i] = new Player(name, goals);
    }
    return players;
}

void WriteArrayToConsole(Player[] players)
{
    foreach (Player player in players)
    {
        Console.WriteLine($"Player {player.Name} finished with {player.GoalNum} goals");
    }
}