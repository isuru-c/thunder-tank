using System;

namespace Client
{
	public class Coin
	{


		private int value;
		private int startingTime;
		private int duration;

		public Coin (int value, int startTime, int duration)
		{
			this.value = value;
			this.startingTime = startTime;
			this.duration = duration;
		}

		public int Value(){
			return value;
		}

	}
}

