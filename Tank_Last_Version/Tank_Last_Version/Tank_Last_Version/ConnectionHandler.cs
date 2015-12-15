using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Tank_Last_Version
{
    class ConnectionHandler
    {
        Connection connection;

        public ConnectionHandler(Parser parser)
        {
            connection = new Connection(parser);
        }

        public bool connect()
        {
            bool success = connection.Send("JOIN#");

            if (success)
            {
                var readingThread = new Thread(connection.Listen);
                readingThread.IsBackground = true;
                readingThread.Start();
            }

            return success;
        }

        public bool moveUp()
        {
            bool success = connection.Send("UP#");
            return success;
        }

        public bool moveRight()
        {
            bool success = connection.Send("RIGHT#");
            return success;
        }

        public bool moveDown()
        {
            bool success = connection.Send("DOWN#");
            return success;
        }

        public bool moveLeft()
        {
            bool success = connection.Send("LEFT#");
            return success;
        }

        public bool shoot()
        {
            bool success = connection.Send("SHOOT#");
            return success;
        }
    }
}
