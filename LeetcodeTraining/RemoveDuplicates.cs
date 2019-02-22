using System;
using System.Collections.Generic;
using System.Text;

namespace LeetcodeTraining
{
    public static class RemoveDuplicatesSolution
    {
        static public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0) return 0;

            int newLength = 1;
            int prevNumber = nums[0];


            for (int i = 1; i < nums.Length; ++i)
            {
                for (int j = i; j < nums.Length; j++)
                {
                    if (nums[j] > prevNumber)
                    {
                        nums[i] = nums[j];
                        prevNumber = nums[j];
                        ++newLength;
                        break;
                    }
                }
            }

            return newLength;
        }
    }
}
