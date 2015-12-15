using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tank_Last_Version.objects
{
    class Coin : MapObject
    {
        int life_time;
        int value;

        public Coin(int x, int y,int lt , int value)
            : base(x, y)
        {
            this.value = value;
            this.life_time = lt;
        }
    }
}
