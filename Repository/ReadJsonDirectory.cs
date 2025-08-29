using Game_Data_Parser.VideoGameDirectory;
using System.Text.Json;
namespace Game_Data_Parser.VideoGameRepository;

  
public class ReadJsonDirectory : Repository
{
  public void ReadJson(List<VideoGame> gameDirectory, string filePath)
  {

    var _deserializedDirectory = JsonSerializer.Deserialize<List<VideoGame>>(filePath);
}
}