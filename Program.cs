using Game_Data_Parser.App;
using Game_Data_Parser.VideoGameDirectory;
using Game_Data_Parser.VideoGameRepository;

var _videoGameDirectory = new VideoGameDirectory();
var _videoGameRepository = new Repository();
var _application = new App(_videoGameDirectory.GameDirectory, _videoGameRepository);

_application.Run();

Console.ReadKey();
