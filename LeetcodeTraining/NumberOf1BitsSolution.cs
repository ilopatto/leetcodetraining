using System;
using System.Collections.Generic;
using System.Text;

namespace LeetcodeTraining
{
    static public class NumberOf1BitsSolution
    {
        public static int HammingWeight(uint number)
        {
            uint mask = uint.MaxValue << 1;
            number = ~number;
            int countBits = 0;

            for (int i = 0; i < 32; ++i)
            {
                if (~(number | mask) == 1)
                {
                    ++countBits;
                }
                number >>= 1;
            }
            return countBits;
        }
    }
}
