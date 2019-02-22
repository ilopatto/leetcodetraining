using System;
using System.Collections.Generic;
using System.Text;

namespace LeetcodeTraining
{
    //NOT DONE

    static class NonDecreasingArray
    {
        static public bool CheckPossibility(int[] nums)
        {
            List<int> maxIncreasingSeries = new List<int>(nums.Length);

            int increasingSeries = 1;

            for(int i = 0; i < nums.Length - 1; ++i)
            {
                if (nums[i] <= nums[i + 1])
                {
                    increasingSeries++;
                }
                else
                {
                    maxIncreasingSeries.Add(increasingSeries);
                    increasingSeries = 1;
                }
            }

            maxIncreasingSeries.Add(increasingSeries);

            return false;
        }
    }
}
