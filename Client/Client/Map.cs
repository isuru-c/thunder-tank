using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Client.Objects;

namespace Client
{
    class Map
    {
        MapObject[][] map;
        public int mapSize { get; set; }

        String name{get; set;}


        public Map(int mapSize)
        {
            this.mapSize = mapSize;
            this.map = new MapObject [mapSize][];
            for (int i = 0; i < map.Length; ++i)
            {
                map[i] = new MapObject[mapSize];
            }
        }

        public void setSpot(int x, int y, MapObject mapObject)
        {
            map[x][y] = mapObject;
        }
        
        public MapObject getSpot(int x, int y)
        {
            return map[x][y];
        }

        public void RemovePlayers()
        {
            for (int i = 0; i < mapSize; ++i)
            {
                for (int j = 0; j < mapSize; ++j)
                {
                    if (map[i][j] == null)
                        continue;
                    else if (map[i][j] is Player)
                        map[i][j] = null;
                }
            }
        }
    }
}
