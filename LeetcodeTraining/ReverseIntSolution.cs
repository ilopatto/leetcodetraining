using System;
using System.Collections.Generic;
using System.Text;

namespace LeetcodeTraining
{
    static public class ReverseIntSolution
    {
        public static int ReverseInt(int number)
        {
            int result = 0;
            bool negativeSign = false;

            if (number < 0)
            {
                negativeSign = true;
                number *= -1;
            }

            while (number > 0)
            {
                try
                {
                    checked
                    {
                        result *= 10;
                        result += number % 10;
                    }
                }
                catch (System.OverflowException)
                {
                    return 0;
                }

                number /= 10;
            }

            if (negativeSign)
            {
                result *= -1;
            }

            return result;
        }
    }
}
