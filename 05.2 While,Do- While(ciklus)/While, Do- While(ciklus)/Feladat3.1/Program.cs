﻿using System.Globalization;

int guess;
int lives = 5;
bool isNumber;

Random rnd = new Random();

int Number = rnd.Next(0,10);
do
{
    Console.WriteLine("Guess the number between 0 and 9: ");
    string input = Console.ReadLine();

    isNumber = int.TryParse(input, new CultureInfo("en-US"), out guess);

    Console.Write(Number);

    if (!isNumber)
    {
        Console.WriteLine("Input is not a number");
    }

    else if (guess < 0 || guess > 9)
    {
        Console.WriteLine("Input is not within the range");
    }
    
    lives--;
    Console.WriteLine($"Tries remaining: {lives}");

} while (!isNumber || guess < 0 || guess > 9 || lives > 0 && guess != Number);

if (guess == Number)
{
    Console.Write("Your guess was correct");
}
else
{
    Console.Write("Your guesses were incorrect");
}