using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Client.Objects
{
    class Player : MapObject
    {
        String name { get; set; }
        int direction { get; set; }
        int whetherShot { get; set; }
        int points { get; set; }
        int coins { get; set; }
        int health { get; set; }

        public Player(String name, int direction, int whetherShot, int health, int coins, int points)
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
