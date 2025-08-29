using Game_Data_Parser.VideoGameDirectory;
using System.Text.Json;

namespace Game_Data_Parser.VideoGameRepository
{
public class Repository
{
  public void Read(List<VideoGame> gameDirectory)
    {
      foreach (VideoGame videoGame in gameDirectory)
      {
        System.Console.WriteLine($"Title: {videoGame.Name}\r\nRelease Year: {videoGame.ReleaseYear} \r\nRating: {videoGame.Rating}\r\n**********");
      }
    }
  public void WriteJson(string filePath, List<VideoGame> directory)
    {

      var _videoGameToDirectory = JsonSerializer.Serialize(directory);
      File.WriteAllText(filePath, _videoGameToDirectory);
      System.Console.WriteLine(_videoGameToDirectory);
    }

  public List<VideoGame> ReadJson(string filePath)
  {
    return JsonSerializer.Deserialize<List<VideoGame>>(filePath);
  }
}
}
