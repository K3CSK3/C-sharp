
    public class PlayerNameAndHeightWithDifferenceofTheAverage
    {


    
        public string PlayerName { get; set; }

        public int Height { get; set; }

    public double AverageHeight { get; set; }

    public double DifferenceOfHeightAndAverage => AverageHeight - Height;

        public PlayerNameAndHeightWithDifferenceofTheAverage() { }
        public PlayerNameAndHeightWithDifferenceofTheAverage(string playerName, int height, double averageHeight)
        {
            PlayerName = playerName;
            Height = height;
        AverageHeight = averageHeight;
        }

        public override string ToString()
        {
            return $"{PlayerName}, {Height} cm, A különbsége az átlagmagasságtól : {DifferenceOfHeightAndAverage:F2}";
        }

    


}

