public class GenreCount
{
    public string Genre { get; set; }
    public int Count { get; set; }

    public GenreCount() { }

    public GenreCount(string genre, int count)
    {
        this.Genre = genre;
        this.Count = count;
    }

    public override string ToString()
    {
        return $"Genre: {this.Genre} has {this.Count} games";
    }
}