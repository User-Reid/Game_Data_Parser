using Game_Data_Parser.VideoGameRepository;
using Game_Data_Parser.VideoGameDirectory;

namespace Game_Data_Parser.App
{
  
public class App
{
  public List<VideoGame> GameDirectory { get; }
  public Repository GameRepository { get; }

  public App(List<VideoGame> gameDirectory, Repository gameRepository)
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
      if (!File.Exists("video-game-directory.json"))
      {
        GameRepository.WriteJson("video-game-directory.json", GameDirectory);
      }
      else
      {
        System.Console.WriteLine("You already have a video-game-directory file :)");
      }

      System.Console.WriteLine("Reading file from JSON now..");
      System.Console.WriteLine("Printing JSON now..");
      List<VideoGame> _directory = GameRepository.ReadJson("video-game-directory.json");
      GameRepository.Read(_directory);
      System.Console.WriteLine("it should have printed above.");

    // writeToDirectory.WriteJson(GameDirectory);
    }
}
}