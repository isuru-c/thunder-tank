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
        int mapSize;

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

        public void setSpot(int row, int col, MapObject g)
        {
            map[row][col] = g;
        }
        
        public MapObject getSpot(int row, int col)
        {
            return map[row][col];
        }
    }
}
