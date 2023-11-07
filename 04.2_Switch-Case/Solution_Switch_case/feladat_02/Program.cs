Console.Write("Please enter a month's name: ");
string month = Console.ReadLine().ToLower();

int? monthNumber = month switch
{
    "January" => 1,
    "February" => 2,
    "March" => 3,
    "April" => 4,
    "May" => 5,
    "June" => 6,
    "July" => 7,
    "August" => 8,
    "September" => 9,
    "October" => 10,
    "November" => 11,
    "December" => 12,
    _ => null,
};
if (monthNumber == null)
{
    Console.WriteLine("Ilyen hónap nincs");
}
else
{
    Console.WriteLine(monthNumber);
}


Console.ReadKey();