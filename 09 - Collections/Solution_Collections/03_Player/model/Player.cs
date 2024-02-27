    public class Player
    {
        public string Name { get; set; }

        public int Height { get; set; }
        public string Post {  get; set; }
        public string Nationality { get; set; }

    public string Team { get; set; }
    public string Country { get; set; }

    public Player() { }

    public Player(string name, int height, string post, string nationality, string team, string country)
    {
        Name = name;
        Height = height;
        Post = post;
        Nationality = nationality;
        Team = team;
        Country = country;
    }

    public override string ToString()
    {
        return $"{Name} - {Height} cm - {Post} - {Nationality} - {Team} - {Country}";
    }
}

