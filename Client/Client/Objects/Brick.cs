using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Client.Objects
{
    class Brick : MapObject
    {
        int strength { get; set; }

        public Brick(int strength)
        {
            this.strength = strength;
        }
    }
}
