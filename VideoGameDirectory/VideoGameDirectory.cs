namespace Game_Data_Parser.VideoGameDirectory
{
  public class GameDirectory
  {
    List<Game> Games { get; } = new List<Game>();

  public GameDirectory(Game _game) {
      Games.Add(_game);
  }
  }
}