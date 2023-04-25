using System;
namespace AbstractClasses
{
    public class PingIPV4 : BasePing
    {

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

