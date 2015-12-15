using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tank_Last_Version.objects
{
    class Tank : MapObject
    {
        public String name { get; set; }
        public int direction { get; set; }
        int whetherShot { get; set; }
        int points { get; set; }
        int coins { get; set; }
        int health { get; set; }

        public Tank(int x,int y,String name, int direction, int whetherShot, int health, int coins, int points)
            :base(x,y)
        {
            this.name = name;
            this.direction = direction;
            this.whetherShot = whetherShot;
            this.health = health;
            this.coins = coins;
            this.points = points;
        }
      
    }
}
