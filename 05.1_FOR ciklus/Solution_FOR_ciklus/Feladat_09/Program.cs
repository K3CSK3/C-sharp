﻿bool isNumber;
int start;
int end;

do
{
    Console.WriteLine("Please type the a number: ");
    string input = Console.ReadLine();
    isNumber = int.TryParse(input, out start);
} while (!isNumber);

do
{
    Console.WriteLine("Please type a number smaller than the previous: ");
    string input = Console.ReadLine();
    isNumber = int.TryParse(input, out end);
} while (!isNumber || end > start);

if (start % 2 == 1)
{
    start++;
}
for (int i = start; i >= end; i -= 2)
{
    Console.WriteLine(i);
}
