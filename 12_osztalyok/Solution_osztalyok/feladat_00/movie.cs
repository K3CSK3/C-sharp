
internal class Movie
{

    public int ReleaseYear { get; set; }

    public string MovieName { get; set; }

    public string Director { get; set; }

    public int MovieLength { get; set; }

    public string Genre { get; set; }

    public override string ToString()
    {
        return $"\n-------------------\n{this.MovieName}({this.ReleaseYear}) directed by {this.Director}\nGenre: {this.Genre}\nLength: {this.MovieLength} minutes\n-------------------\n";
    }
}
