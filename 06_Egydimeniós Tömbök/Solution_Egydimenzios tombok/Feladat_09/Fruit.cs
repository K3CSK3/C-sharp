public class Fruit
{
    public string Name { get; set; }
    public double Weight { get; set; }
    public double Price { get; set; }

    public Fruit(string name, double weight, double price)
    {
        this.Name = name;
        this.Weight = weight;
        this.Price = price;
    }
    public override string ToString()
    {
        return $"Fruit name:{this.Name}\nAmount:{this.Weight}\nPrice:{this.Price}";
    }
}
