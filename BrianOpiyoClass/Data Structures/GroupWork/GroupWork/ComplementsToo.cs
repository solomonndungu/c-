using System;
namespace GroupWork
{
	public class ComplementsToo: Complement
	{
        public override Dictionary<string, string> Complements(int[] arrIter, int targetSum)
        {

            HashSet<int> uniqueArr = new HashSet<int>(arrIter);
            Dictionary<string, string> candidateNums = new Dictionary<string, string>();

            foreach (int i in uniqueArr)
            {
                int firstNum = i;

                foreach (int j in uniqueArr)
                {
                    int secondNum = j;

                    if ((firstNum + secondNum) == targetSum)
                    {
                        candidateNums.Add($"{firstNum} + {secondNum}", Array.IndexOf(arrIter, firstNum) + ", " + Array.IndexOf(arrIter, secondNum));
                    }
                }
                uniqueArr.Remove(firstNum);
            }

            return candidateNums;
        }

  
           
	}
}

