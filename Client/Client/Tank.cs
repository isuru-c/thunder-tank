using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading;

namespace Client
{
    class Tank
    {
        Connection connection;

        public Tank(Parser parser)
        {
            connection = new Connection(parser);
        }

        public void Connect()
        {
            connection.Send("JOIN#");

            var readingThread = new Thread(connection.Listen);
            readingThread.Start();
        }

        public void MoveUp()
        {
            connection.Send("UP#");
        }

        public void MoveRight()
        {
            connection.Send("RIGHT#");
        }

        public void MoveDown()
        {
            connection.Send("DOWN#");
        }

        public void MoveLeft()
        {
            connection.Send("LEFT#");
        }

        public void Shoot()
        {
            connection.Send("SHOOT#");
        }
    }
}
