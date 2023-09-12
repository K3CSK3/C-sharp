
Console.Write("Please type your name: ");
string name = Console.ReadLine();

Console.Write("Please press a key: ");
char keyPressed = Console.ReadKey().KeyChar;

Console.Write($"{name} ön a/az {keyPressed} billentyűt nyomta meg!");