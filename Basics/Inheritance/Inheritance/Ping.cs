using System;
namespace Inheritance
{
	public class Ping : BaseNetworkUtility
	{
		public override void Send()
		{
			Console.WriteLine("Pinging... Ping sent");
		}

	}

}