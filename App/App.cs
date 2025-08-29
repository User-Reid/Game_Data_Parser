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

    GameRepository.ReadJson("video-game-directory");

    // writeToDirectory.WriteJson(GameDirectory);
  }
}
}