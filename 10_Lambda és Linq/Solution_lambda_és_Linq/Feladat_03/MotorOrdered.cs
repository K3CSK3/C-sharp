
    internal class MotorOrdered
    {
    public string MotorName { get; set; }

    public int ReleaseYear { get; set; }

    public MotorOrdered() { }

    public MotorOrdered(string motorName, int releaseYear)
    {
        MotorName = motorName;
        ReleaseYear = releaseYear;
    }
}