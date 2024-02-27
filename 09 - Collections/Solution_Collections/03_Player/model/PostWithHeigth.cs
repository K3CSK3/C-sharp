
    public class PostWithHeigth
    {
        public string PostName { get; set; }

        public List<int> PlayersHeights { get; set; }

        public int SumOfHeights => PlayersHeights.Sum();

    public PostWithHeigth() { }

    public PostWithHeigth(string postName, List<int> playersHeights)
    {
        PostName = postName;
        PlayersHeights = playersHeights;
    }

    public override string ToString()
    {
        return $"{PostName} : {SumOfHeights} cm";
    }
}

