using IOLibrary;
using System.Threading.Channels;

const int NUMBER_OF_SONGS = 10;

Song[] songs = GetSongs();
Console.Clear();
ExtendedSystem.WriteArrayToConsole(songs);


int totalLength = songs.Sum(song => song.Length);
Console.WriteLine($"\nThe total length of the disc is {totalLength/60} minutes");


double averageLength = songs.Average(song => song.Length);
Console.WriteLine($"\nThe average length of a song on the disc is {(averageLength/60):F0}:{(averageLength % 60):F0}");


int shortestSongLength = songs.Min(song => song.Length);
Song shortestSong = songs.First(song => song.Length == shortestSongLength);
Console.WriteLine($"\nThe shortest music on the disc is {shortestSong}");


bool moreThan4Min = songs.Any(song => song.Length > 240);
Console.WriteLine($"\nThere {(moreThan4Min?"were":"weren't")} song(s) longer than 4 minutes");


int longestSongLength = songs.Max(song => song.Length);
Song longestSong = songs.First(song => song.Length == longestSongLength);
Console.WriteLine($"\nThe longest song was track number {longestSong.Place}");

int sameLengthSongsAmount = SameLengthSongs(songs);
Console.WriteLine($"\nThere {((sameLengthSongsAmount == 0) ? "aren't" : "are")} songs with the same length");

if (sameLengthSongsAmount != 0)
{
    Song[] sameLen = SameLengthSongNames(sameLengthSongsAmount, songs);
    //ExtendedSystem.WriteArrayToConsole(sameLen);
}

int SameLengthSongs(Song[] songs)
{
    int counter = 0;
    for (int i = 0; i < NUMBER_OF_SONGS; i++)
    {
        counter += songs.Count(x => x.Length == songs[i].Length) - 1;
    }
    return counter;
}

Song[] SameLengthSongNames(int number, Song[] songs)
{
    Song[] sameLen = new Song[number];
    for (int i = 0; i<number; i++)
    {
        for (int j = 0; j<number; j++)
        {
            if ((songs[i].Length == songs[j].Length) && (i != j))
            {
                sameLen[i] = songs[j];
                Console.WriteLine(sameLen[i].Length);
            }
        }
    }    
    return sameLen;
}

Song[] GetSongs()
{
    Song[] songs = new Song[NUMBER_OF_SONGS];
    Random rnd = new Random();

    for (int i = 0; i < NUMBER_OF_SONGS; i++)
    {
        string name = "a"; //ExtendedConsole.ReadString("Please type the song\'s name: ");
        int length = rnd.Next(30, 51);
        songs[i] = new Song(name, length, i + 1);
    }
    return songs;
}