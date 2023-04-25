using System;
namespace Inheritance
{
	public class BaseNetworkUtility
	{
        public int HostAddress { get; set; }

        public int DestAddress { get; set; }

        public int Data { get; set; }

        public virtual void Send()
        {
            Console.WriteLine("Send");
        }

    }
}

