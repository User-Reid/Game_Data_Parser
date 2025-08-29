using Game_Data_Parser.VideoGameDirectory;

namespace Game_Data_Parser.App

{
  public class Run {
    public GameDirectory _gameDirectory;
    public GameRepository _gameRepository;
    public Run(GameDirectory Directory, GameRepository Repository)
    {
      _gameDirectory = Directory;
      _gameRepository = Repository;

      if (!File.Exists("gameDirectory.json"))
      {
        System.Console.WriteLine("Welcome to the Game Data Parser! Let's get started!");
      }
      else
      {
        PrintRepository();
        System.Console.WriteLine("What would you like to add to your current repository?");
      }
      
      VideoGameDirectoryCreation();
    }
  }
}