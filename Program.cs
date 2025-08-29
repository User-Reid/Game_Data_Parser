using System.Diagnostics.CodeAnalysis;
using System.Text.Json;

var _videoGameDirectory = new VideoGameDirectory();
var _videoGameRepository = new VideoGameRepository();
var _application = new App(_videoGameDirectory.GameDirectory, _videoGameRepository);

_application.Run();

Console.ReadKey();

public class App
{
  public List<VideoGame> GameDirectory { get; }
  public VideoGameRepository GameRepository {get;}

  public App(List<VideoGame> gameDirectory, VideoGameRepository gameRepository)
  {
    GameDirectory = gameDirectory;
    GameRepository = gameRepository;
  }

  public void Run()
  {
    new AddToDirectory(GameDirectory);
    GameRepository.Read(GameDirectory);
    new AddToDirectory(GameDirectory);
    GameRepository.Read(GameDirectory);
    
    // writeToDirectory.WriteJson(GameDirectory);
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

// public interface IVideoGameRepository {
//   public void Write(List<VideoGame> gameDirectory);
//   public void Read(List<VideoGame> gameDirectory, string filePath);
// }

// Now i have to make it so that the user input sets the values for the coresponding VideoGame object. It then adds the object to the VideoGame Directory list.
public class AddToDirectory
{
  public AddToDirectory(List<VideoGame> gameDirectory)
  {
    // var newGame = new VideoGame("Halo", 2030, 3.6);
    System.Console.WriteLine("What is the name of the game you would like to add?😄");
    var name = Console.ReadLine();
    System.Console.WriteLine("What year was the game released?⌛");
    var releaseYear = int.Parse(Console.ReadLine());
    System.Console.WriteLine("Finally, what would you rate this game 1.0 - 5.0?⭐");
    var rating = double.Parse(Console.ReadLine());
    var newGame = new VideoGame(name, releaseYear, rating);

    gameDirectory.Add(newGame);
    System.Console.WriteLine($"{newGame.Name}\r\nHas been added to your directory!");
  }

}

public interface IVideoGameRepository
{
  void Read(List<VideoGame> gameDirectory);
  void Write(string filePath, List<VideoGame> directory);
}

// public class VideoGameRepository : IVideoGameRepository
public class VideoGameRepository

{
  public void Read(List<VideoGame> gameDirectory)
  {
    foreach (VideoGame videoGame in gameDirectory)
    {
      System.Console.WriteLine($"Title: {videoGame.Name}\r\nRelease Year: {videoGame.ReleaseYear} \r\nRating: {videoGame.Rating}");
    }
  }
  // public void Write(string filePath, List<VideoGame> directory)
  // {
  //   var writeToDirectory = new WriteToDirectory();
  //   foreach (VideoGame videoGame in directory) {
      
  //   }

  //   writeToDirectory.WriteJson(filePath, );
  // }
  
}

public class WriteToDirectory : VideoGameRepository
{
  public void WriteJson(string filePath, List<string> videoGame)
  {
    var _videoGameToDirectory = JsonSerializer.Serialize(videoGame);
    File.WriteAllText(filePath, _videoGameToDirectory);
    System.Console.WriteLine(_videoGameToDirectory);
  }
}

public class ReadDirectory : VideoGameRepository
{
  public void ReadJson(List<VideoGame> gameDirectory, string filePath)
  {

          var _deserializedDirectory = JsonSerializer.Deserialize<List<VideoGame>>(filePath);

    
  }
}