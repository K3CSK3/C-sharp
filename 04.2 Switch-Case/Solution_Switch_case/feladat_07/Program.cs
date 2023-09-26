Human person1 = new Human();
Console.Write("Please type your name: ");
person1.Name = Console.ReadLine();

Console.Write("Please type your age: ");
person1.Age = int.Parse(Console.ReadLine());

Console.Write("Please type your weight: ");
person1.Weight = int.Parse(Console.ReadLine());

Console.Write("Please type your benchpress amount: ");
person1.BenchpressAmount = double.Parse(Console.ReadLine());

person1.Strength = person1.BenchpressAmount /person1.Weight;

person1.Rating = person1.Strength switch
{
    > 1 => "god",
    > 0.6 => "professional",
    > 0.4 => "advanced",
    > 0.2 => "begginer",
    _ => "none"
};

Console.Write(person1);


Human person2 = new Human();
Console.Write("\nPlease type your name: ");
person2.Name = Console.ReadLine();

Console.Write("Please type your age: ");
person2.Age = int.Parse(Console.ReadLine());

Console.Write("Please type your weight: ");
person2.Weight = int.Parse(Console.ReadLine());

Console.Write("Please type your benchpress amount: ");
person2.BenchpressAmount = double.Parse(Console.ReadLine());

person2.Strength = person2.BenchpressAmount / person2.Weight;

person2.Rating = person2.Strength switch
{
    > 1 => "god",
    > 0.6 => "professional",
    > 0.4 => "advanced",
    > 0.2 => "begginer",
    _ => "none"
};

Console.Write(person2);