int number;
bool isNumber;

do
{
    Console.Write("Please type a 3 digit number: ");
    string input = Console.ReadLine();

    isNumber = int.TryParse(input, out number );
    number = Math.Abs( number );

}
while ( !isNumber || (number < 100 || number > 999) );

if (number % 7 == 0)
{
    Console.WriteLine("Number is divisble by 7");
}
else
{
    Console.WriteLine("Number is NOT divisble by 7");
}