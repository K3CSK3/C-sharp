
Console.Write("Please type the artists name");
string bandName = Console.ReadLine();

Console.Write("Please type the songs name");
string songName = Console.ReadLine();

Console.Write("Please the songs length: ");
int songLength = int.Parse(Console.ReadLine());

Console.WriteLine($"Az ön kedvenc együttesének {bandName} a legjobb zeneszáma {songName} melynek hossza {songLength} perc !");