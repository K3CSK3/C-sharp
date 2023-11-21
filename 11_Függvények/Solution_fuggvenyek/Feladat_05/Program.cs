using IOLibrary;

Console.WriteLine("Please type a word");
string firstWord = ExtendedConsole.ReadString();

Console.WriteLine($"Please type a word that should be compared to {firstWord}");
string secondWord = ExtendedConsole.ReadString();

int sameLetterAmount = 0;

for (int i = 0; i<(firstWord.Length); i++)
{
    for (int j = 0; j < (secondWord.Length); j++)
    {
        if (firstWord[i] == secondWord[j])
        {
            sameLetterAmount++;
            secondWord.Replace($"{i}", "");
        }
    }
}


Console.WriteLine($"{sameLetterAmount} letter are similar in \"{firstWord}\" and \"{secondWord}\"");