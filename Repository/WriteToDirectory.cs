using System.Text.Json;
namespace Game_Data_Parser.VideoGameRepository;
public class WriteToDirectory : Repository
{
  public void WriteJson(string filePath, List<string> videoGameDirectory)
  {
    var _videoGameToDirectory = JsonSerializer.Serialize(videoGameDirectory);
    File.WriteAllText(filePath, _videoGameToDirectory);
    System.Console.WriteLine(_videoGameToDirectory);
  }
}
