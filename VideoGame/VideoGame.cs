namespace Game_Data_Parser.VideoGameDirectory
{
public class VideoGame
{
  public string Name { get; }
  public int ReleaseYear { get; }
  public double Rating { get; }

  public VideoGame(string name, int releaseYear, double rating)
  {
    Name = name;
    ReleaseYear = releaseYear;
    Rating = rating;
  }
}
}