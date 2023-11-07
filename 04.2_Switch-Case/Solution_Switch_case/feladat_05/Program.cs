Console.Write("Please enter a number: ");
int r1 = int.Parse(Console.ReadLine());

Console.Write("Please enter another number: ");
int r2 = int.Parse(Console.ReadLine());

Console.Write("Please enter the type of connection(s or p): ");
string sign = Console.ReadLine().ToLower();

double? result = sign switch
{
    "p" =>(double) ((r1 + r2)/ (r1/r2)),
    "s" => r1 + r2,
    _ => null,
};
if (result == null)
{
    Console.WriteLine("Ilyen operátor nincs");
}
else
{
    Console.WriteLine(result);
}
Console.ReadKey();