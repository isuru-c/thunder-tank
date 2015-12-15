using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tank_Last_Version.objects
{
    class Brick : MapObject
    {
        public int damageLevel {get; set;}

        public Brick() : base() { }

        public Brick(int x, int y) : base(x,y) { }

        public Brick(int x, int y, int dmg_level)
            : base(x, y)
        {
            this.damageLevel = dmg_level;
        }

    }
}
