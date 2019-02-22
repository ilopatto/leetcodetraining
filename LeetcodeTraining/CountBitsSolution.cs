using System;
using System.Collections.Generic;
using System.Text;

namespace LeetcodeTraining
{
    static public class CountBitsSolution
    {
        public static int[] CountBits(int num)
        {
            int[] resultArray = new int[num + 1];
            uint mask = uint.MaxValue << 1;

            for (uint i = 0; i <= num; ++i)
            {
                uint number = ~i;
                int countBits = 0;

                for (int j = 0; j < 32; ++j)
                {
                    if (~(number | mask) == 1)
                    {
                        ++countBits;
                    }
                    number >>= 1;
                }
                resultArray[i] = countBits;
            }
            return resultArray;
        }
    }
}
