using Game_Data_Parser.VideoGameDirectory;

namespace Game_Data_Parser.Repository
{
  
  public class WriteToGameRepository
  {
    public GameDirectory Run()
    {
      string gameName;
      int gameReleaseYear;
      double rating;

      do
      {
        System.Console.WriteLine("What is the name of the game you would like to add😄");
        gameName = Console.ReadLine();
        System.Console.WriteLine("What is the release year of the game⌛");
        gameReleaseYear = int.Parse(Console.ReadLine());
        System.Console.WriteLine("What would you rate this game?");
        rating = double.Parse(Console.ReadLine());
      } while (string.IsNullOrEmpty(gameName) || gameReleaseYear <= 1950 || rating <= 0.0 || rating >= 5.1);

      GameDirectory gameDirectory = new GameDirectory(new Game(gameName, gameReleaseYear, rating));
      return gameDirectory;
    }
  }
}