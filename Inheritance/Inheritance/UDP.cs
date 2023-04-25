using System;
namespace Inheritance
{
	public class UDP : BaseNetworkUtility
	{
        public override void Send()
        {
            Console.WriteLine("Sending UDP... UDP sent");
        }
    }
}

