namespace Game_Data_Parser.VideoGameDirectory
{
  public class Game : GameDirectory
  {
    public string Title { get; }
    public int ReleaseYear { get; }
    public double Rating { get; }
    public Game(string title, int releaseYear, double rating)
    {
      Title = title;
      ReleaseYear = releaseYear;
      Rating = rating;
    }
  }
}