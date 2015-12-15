using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tank_Last_Version.objects
{
    class LifePack : MapObject
    {
        int life_time;
        public LifePack(int x, int y, int lt)
            : base(x, y)
        {
            this.life_time = lt;
        }
    }
}
