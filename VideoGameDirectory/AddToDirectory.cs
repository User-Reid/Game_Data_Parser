namespace Game_Data_Parser.VideoGameDirectory
{
public class AddToDirectory : VideoGameDirectory
{
  public AddToDirectory(List<VideoGame> gameDirectory)
  {
    System.Console.WriteLine("What is the name of the game you would like to add?😄");
    var name = Console.ReadLine();
    System.Console.WriteLine("What year was the game released?⌛");
    var releaseYear = int.Parse(Console.ReadLine());
    System.Console.WriteLine("Finally, what would you rate this game 1.0 - 5.0?⭐");
    var rating = double.Parse(Console.ReadLine());
    var newGame = new VideoGame(name, releaseYear, rating);

    gameDirectory.Add(newGame);
    System.Console.WriteLine($"{newGame.Name} has been added to your directory!");
  }
}
}
