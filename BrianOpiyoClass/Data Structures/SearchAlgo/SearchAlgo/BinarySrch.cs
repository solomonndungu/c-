using System;
namespace SearchAlgo
{
	public class BinarySrch: MidPnt
	{
        public int BinarySearch(int[] nums, int target, int currMid = 0)
        {
           // Console.WriteLine(LogArray(nums)); Using this in Main

            if (nums.Length == 1)
                if (nums[0] == target)
                    return 0;
                else
                    return -1;

            int arrMid = MidPoint(nums.Length);
            if (arrMid >= 0 && arrMid < nums.Length)
            {
                if (nums[arrMid] == target)
                    return arrMid;
                else
                {
                    List<int> leftArr = new List<int>();
                    List<int> rightArr = new List<int>();

                    for (int i = 0; i < nums.Length; i++)
                    {
                        if (i > arrMid)
                            rightArr.Add(nums[i]);
                        else if (i < arrMid)
                            leftArr.Add(nums[i]);
                    }
                    Dictionary<string, int[]> twoHalves = new Dictionary<string, int[]>();
                    twoHalves.Add("left", leftArr.ToArray());
                    twoHalves.Add("right", rightArr.ToArray());
                    int final = -1;
                    foreach (var half in twoHalves)
                    {
                        if (half.Key == "left")
                            currMid = -1;
                        else
                            currMid = arrMid;

                        var result = BinarySearch(half.Value, target, currMid);
                        if (result == -1)
                            continue;
                        else
                        {
                            return result + currMid + 1;
                        }

                    }

                    return final;
                }
            }
            else
                return -1;
        }

    }
}

