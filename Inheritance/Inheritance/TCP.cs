using System;
namespace Inheritance
{
	public class TCP : BaseNetworkUtility
	{
        public override void Send()
        {
            Console.WriteLine("Sending TCP... TCP sent");
        }
    }
}

