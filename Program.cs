var _videoGameDirectory = new VideoGameDirectory();
var _application = new App(_videoGameDirectory.GameDirectory);

_application.Run();

Console.ReadKey();

public class App
{
  public List<VideoGame> GameDirectory { get; }

  public App(List<VideoGame> gameDirectory)
  {
    GameDirectory = gameDirectory;
  }

  public void Run()
  {
    var writeToDirectory = new WriteToDirectory();

    writeToDirectory.Write(GameDirectory);


  }
}
public class VideoGameDirectory
{
  public List<VideoGame> GameDirectory { get; } = new List<VideoGame>();
}

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

public class WriteToDirectory
{
  public void Write(List<VideoGame> gameDirectory)
  {
    gameDirectory.Add(new VideoGame("Halo", 2030, 3.6));
    System.Console.WriteLine($"{gameDirectory[0].Name}, {gameDirectory[0].ReleaseYear},{gameDirectory[0].Rating}");
  }
}