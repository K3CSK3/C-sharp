public class Song
{
    public string Name { get; set; }
    public int Length { get; set; }
    public int Place { get; set; }

    internal int Minutes { get; }
    internal int Seconds { get; }

    public Song(string name, int length, int place)
    {
        this.Name = name;
        this.Length = length;
        this.Place = place;

        this.Minutes = Length / 60;
        this.Seconds = Length % 60;
    }

    public override string ToString()
    {
        return $"{this.Place} - {this.Name} ({this.Minutes}:{(this.Seconds<10?"0":"")}{this.Seconds})";
    }
}
