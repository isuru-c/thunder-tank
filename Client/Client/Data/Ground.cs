using System;

namespace Client
{
	public class Ground
	{
		int groundSize;
		char[][] map;


		private static Ground ground = new Ground();

		public Ground ()
		{
			groundSize = 10;
		}

		public static Ground getGround(){
			return ground;
		}
	}
}

