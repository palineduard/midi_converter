using System.Collections.Generic;

namespace MIDIConverter.LevelData
{
	public class LevelData
    {
        private string levelName;
        private List<List<TileData>> tilesData;
        private LevelDifficulty difficulty;
        private string song;

        public LevelData(string levelName, LevelDifficulty difficulty, string song)
		{
            this.levelName = levelName;
            this.difficulty = difficulty;
            this.song = song;
            tilesData = new List<List<TileData>>{
                new List<TileData> { },
                new List<TileData> { },
                new List<TileData> { },
                new List<TileData> { },
            };
        }
        public string LevelName
        {
            get => levelName; 
            set => levelName = value;
        }

        public List<List<TileData>> TilesData
        {
            get => tilesData;
            set => tilesData = value;
        }

        public LevelDifficulty Difficulty
        {
            get => difficulty;  
            set => difficulty = value;
        }

        public string Song
        {
            get => song;
            set => song = value;
        }
    }
}