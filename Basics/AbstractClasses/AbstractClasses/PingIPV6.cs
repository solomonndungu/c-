using System;
namespace AbstractClasses
{
	public class PingIPV6 : BasePing
	{
       // public override bool Init()
      //  {
       //     return false;
        //}
    
        // Different Implementation
        public override bool Init()
        {
            return true;
        }

        public bool SendPing()
		{
			return true;
		}
	}
}

