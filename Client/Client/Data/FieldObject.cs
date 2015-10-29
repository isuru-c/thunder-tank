using System;

namespace Client
{
	public class FieldObject
	{
		String type;

		public FieldObject ()
		{
			this.type = "Empty";
		}

		public void SetType(String type){
			this.type = type;
		}

		public String Type(){
			return type;
		}
	}
}

