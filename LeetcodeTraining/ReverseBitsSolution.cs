using System;
using System.Collections.Generic;
using System.Text;

namespace LeetcodeTraining
{
    static public class ReverseBitsSolution
    {
        static public uint ReverseBits(uint number)
        {
            uint mask = uint.MaxValue << 1;
            number = ~number;
            uint reversed = 0;

            for (int i = 0; i < 32; ++i)
            {
                reversed <<= 1;
                reversed += ~(number | mask);
                number >>= 1;
            }

            return reversed;
        }

    }
}
