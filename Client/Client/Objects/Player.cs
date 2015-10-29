using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Client.Objects
{
    class Player : MapObject
    {
        int direction { get; set; }
        int points { get; set; }
        int coins { get; set; }
        int life { get; set; }
    }
}
