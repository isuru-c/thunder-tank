using System;

using System.Threading;

namespace Client
{
	public class Tank
	{
		Connection connection;

		public Tank ()
		{
			connection = new Connection ();
		}

		public void Connect(){
			connection.Send ("JOIN#");

			var readingThread = new Thread (connection.Listen);
			readingThread.Start ();
		}

		public void MoveUp(){
			connection.Send ("UP#");
		}

		public void MoveRight(){
			connection.Send ("RIGHT#");
		}

		public void MoveDown(){
			connection.Send ("DOWN#");
		}

		public void MoveLeft(){
			connection.Send ("LEFT#");
		}

		public void Shoot(){
			connection.Send ("SHOOT#");
		}
	}
}

