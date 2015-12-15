using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Tank_Last_Version.objects;


namespace Tank_Last_Version
{
    class Map
    {
        MapObject[][] map;
        public int mapSize { get; set; }

        public Map(int mapSize)
        {
            this.mapSize = mapSize;
            this.map = new MapObject[mapSize][];
            for (int i = 0; i < map.Length; ++i)
            {
                map[i] = new MapObject[mapSize];
            }
        }

        private readonly object _syncRoot_1 = new Object();

        public void setSpot(int x, int y, MapObject mapObject)
        {
            lock (_syncRoot_1)
            {
                map[x][y] = mapObject;
            }
        }

        private readonly object _syncRoot_2 = new Object();

        public MapObject getSpot(int x, int y)
        {
            lock (_syncRoot_2)
            {
                return map[x][y];
            }
        }


        private readonly object _syncRoot_3 = new Object();

        public void RemovePlayers()
        {
            lock (_syncRoot_3)
            {
                for (int i = 0; i < mapSize; ++i)
                {
                    for (int j = 0; j < mapSize; ++j)
                    {
                        if (map[i][j] == null)
                            continue;
                        else if (map[i][j] is Tank)
                            map[i][j] = null;
                    }
                }
            }
        }
    }
}
