using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tank_Last_Version.objects
{
   
    class MapObject
    {
        public int posX {get; set;}
        public int posY { get; set; }

        public MapObject() { }

        public MapObject(int x, int y)
        {
            this.posX = x;
            this.posY = y;
        }
    }
}
