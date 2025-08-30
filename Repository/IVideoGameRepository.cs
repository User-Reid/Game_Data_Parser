using Game_Data_Parser.VideoGameDirectory;

namespace Game_Data_Parser.VideoGameRepository;


public interface IVideoGameRepository
{
  public void Write(List<VideoGame> gameDirectory);
  public void Read(List<VideoGame> gameDirectory, string filePath);
}

