using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Client.Objects
{
    class Brick : MapObject
    {
        int damage { get; set; }

        public Brick(int damage)
        {
            this.damage = damage;
        }
    }
}
