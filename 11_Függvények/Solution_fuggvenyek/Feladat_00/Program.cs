using IOLibrary;

Console.WriteLine("Please type a number: ");
int number1 = ExtendedConsole.ReadInteger();

Console.WriteLine("Please type a floating point number: ");
double number2 = ExtendedConsole.ReadDouble();

Console.WriteLine("Please type text: ");
string text = ExtendedConsole.ReadString();

Console.WriteLine("Please type your name");
string name = ExtendedConsole.ReadName();

Console.WriteLine("Please type the year you were born in: ");
int age = ExtendedConsole.GetAge();

number1.WriteToConsole();

number2.WriteToConsole();

text.WriteToConsole();

name.WriteToConsole();

age.WriteToConsole();