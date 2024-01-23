using IOLibrary;

const int NUMBER_OF_PLAYERS = 6;

Player[] players = GetPlayers();

double averageHeight = players.Average(player => player.Height);

Console.Clear();

Console.WriteLine("Shorter than average players:");
Player[] smallPlayers = players.Where(player => player.Height < averageHeight).ToArray();
ExtendedSystem.WriteArrayToConsole(smallPlayers);

double tallerPlayerPercentage = 1- (smallPlayers.Length / (double)NUMBER_OF_PLAYERS);
Console.WriteLine($"\nThe percentage of taller than average players is {tallerPlayerPercentage*100:F2}%");

int totalPoints = players.Sum(player => player.SumOfPoints);
Console.WriteLine($"\nThe team scored {totalPoints} points in total");

int leastPoints = players.Min(player => player.SumOfPoints);
Player LVP = players.First(player => player.SumOfPoints == leastPoints);
Console.WriteLine($"\nThe Least Valuable Player was {LVP} points in total");

int mostPoints = players.Max(player => player.SumOfPoints);
Player MVP = players.First(player => player.SumOfPoints == mostPoints);
Console.WriteLine($"\nThe Most Valuable Player was {MVP} points in total");

int tallest = players.Max(player => player.Height);
Player tallestPlayer = players.First(player => player.Height == tallest);

int shortest = players.Min(player => player.Height);
Player shortestPlayer = players.First(player => player.Height == shortest);

TallSmall tallSmall = new TallSmall(tallestPlayer, shortestPlayer);
Console.WriteLine(tallSmall);

Player[] GetPlayers()
{
    Player[] players = new Player[NUMBER_OF_PLAYERS];

    for (int i = 0; i < NUMBER_OF_PLAYERS; i++)
    {
        string name = "alma";//ExtendedConsole.ReadString("Please type the player\'s name: ");
        int height = ExtendedConsole.ReadInteger("Please type the player\'s height(cm): ",150);
        int sumOfPoints = 12;//ExtendedConsole.ReadInteger("Please type the amount of points scored throughout this year: ", 0);

        players[i] = new Player(name, height, sumOfPoints);
    }
    return players;
}