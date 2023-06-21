using System;
namespace SearchAlgo
{
	public class MidPnt: LogArr
	{
        public int MidPoint(int arraySize)
        {
            if (arraySize % 2 == 0)
            {
                return arraySize / 2;
            }
            else
            {
                return (arraySize / 2) + 1;
            }
        }

    }
}

