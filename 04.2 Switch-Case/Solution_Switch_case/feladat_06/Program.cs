Console.Write("Please enter the lenght of the brick: ");
int lenght = int.Parse(Console.ReadLine());

Console.Write("Please enter the width of the brick: ");
int width = int.Parse(Console.ReadLine());

Console.Write("Please enter wich property of the brick, you want\na - area\np - perimeter\nd - diagonal: ");
string sign = Console.ReadLine().ToLower();

double? result = sign switch
{
    "p" => 2*(lenght+width),
    "a" => lenght * width,
    "d" => (double)(Math.Sqrt(Math.Pow(lenght, 2) + Math.Pow(width, 2))),
    _ => null,
};
if (result == null)
{
    Console.WriteLine("No such property");
}
else
{
    Console.WriteLine(result);
}
Console.ReadKey();