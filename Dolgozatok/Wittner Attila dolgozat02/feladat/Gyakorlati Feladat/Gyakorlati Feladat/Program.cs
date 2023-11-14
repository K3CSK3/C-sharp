int startNumber;
int endNumber;
bool isNumber;

do
{
    Console.Write("Please type the number the counting should begin with: ");
    string input = Console.ReadLine();
    isNumber = int.TryParse(input, out startNumber);
}
while (!isNumber);

do
{
    Console.Write("Please type the number the counting should end with (note that this should be larger): ");
    string input = Console.ReadLine();
    isNumber = int.TryParse(input, out endNumber);
}
while (!isNumber || startNumber > endNumber);


/* GYAKORLATI FELADAT(10)
Virág azt a feladatot kapta az iskolában, hogy két tetszőlegesen megadott szám közt (kezdő és végérték):
feladat – 1:
-Keresse ki és írja ki a mintának megfelelően, hogy mennyi az intervallum számainak összege (1):
Feladat 1:
A {kezdőérték} és a { végérték }
közti számok összege: { összeg }.
*/

int sum = 0;
int count = 0;


for (int i = startNumber; i <= endNumber; i++)
{
    sum += i;
}

Console.WriteLine($"\n------------------------------------------------------\n\nThe sum of numbers between {startNumber} and {endNumber} is: {sum}.");

/*
feladat – 2:
Keresse ki és írja ki a mintának megfelelően, hogy mennyi az intervallum számainak átlagát (1): 
Feladat 2:
A {kezdőérték} és a { végérték }
közti számok átlaga: { átlag }.
*/
for (int i = startNumber; i <= endNumber; i++)
{
    count++;
}

double average = (double) sum / (double) count;

Console.WriteLine($"\n------------------------------------------------------\n\nThe average of numbers between {startNumber} and {endNumber} is: {average}.");

/*
feladat – 3:
-Keresse ki és írja ki a mintának megfelelően, hogy hány páratlan szám van az intervallumban (1):
Feladat 3:
A {kezdőérték} és a { végérték }
közti páratlan számok száma: { páratlan számok száma }.
*/

int countOfOdd = 0;
int begginer = startNumber;

if (startNumber%2 == 0)
{
    begginer++;
}

for (int i = begginer; i <= endNumber; i+=2)
{
    countOfOdd++;
}
Console.WriteLine($"\n------------------------------------------------------\n\nThe count of odd numbers between {startNumber} and {endNumber} is: {countOfOdd}.");

/*
feladat – 4:
-Keresse ki és írja ki a mintának megfelelően, a hárommal osztható számokat (1):
Feladat 4:
A {kezdőérték} és a { végérték }
közti hárommal osztható számok:
3, 6, 9, 12, 15, 18, …
*/

begginer = startNumber + (3 - startNumber % 3);

Console.WriteLine($"\n------------------------------------------------------\n\nNumbers that are divisible by 3 between {startNumber} and {endNumber} are:");
for (int i = begginer; i <= endNumber; i += 3)
{
    Console.Write($"{i}, ");
}


/*
feladat – 5:
-Keresse ki és írja ki a mintának megfelelően, hogy van-e az intervallumban olyan szám mely páros és osztható héttel (1): 

Feladat 5:
A {kezdőérték} és a { végérték }
közt van/nincs olyan szám mely páros és osztható héttel vagy páratlan és osztható héttel, ezek: ...
*/

begginer = startNumber+(7-startNumber%7);

Console.WriteLine($"\n\n------------------------------------------------------\n\nNumbers that are divisible by 7 and are odd between {startNumber} and {endNumber} are:");
for (int i = begginer; i <= endNumber; i += 14)
{
    Console.Write($"{i}, ");
}

begginer = startNumber + (7 - startNumber % 7) + 7;

Console.WriteLine($"\n\n------------------------------------------------------\n\nNumbers that are divisible by 7 and are even between {startNumber} and {endNumber} are:");
for (int i = begginer; i <= endNumber; i += 14)
{
    Console.Write($"{i}, ");
}
Console.ReadKey();