using System;
namespace AbstractClasses
{
	public abstract class BasePing
	{
        public int HostAddress { get; set; }

        public int TestAddress { get; set; }

        public string Data { get; set; }

        // If ping boots, return true
       // public virtual bool Init()
       // {
       //     return true;
       // }

        public abstract bool Init()
        {
            return true;
        }
    }
}

