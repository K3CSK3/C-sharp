using IOLibrary;

Random randomNumber = new Random();

int firstNumber = randomNumber.Next(0, 9);
int secondNumber = randomNumber.Next(40, 50);

int numberToGuess = randomNumber.Next(firstNumber, secondNumber);

Console.WriteLine($"Guess the number between {firstNumber}-{secondNumber}");
int tries = GuessTheNumber(numberToGuess);

Console.WriteLine($"You guessed the number in {tries} tries");

static int GuessTheNumber(int randomNumber)
{
    int guess;
    int tries = 0;
    do
    {
        tries++;
        guess = ExtendedConsole.ReadInteger();
        if (guess < randomNumber)
        {
            Console.WriteLine($"The number to guess is more than {guess}");
        }
        else if (guess > randomNumber)
        {
            Console.WriteLine($"The number to guess is less than {guess}");
        }
    } while (guess != randomNumber);
    return tries;
}