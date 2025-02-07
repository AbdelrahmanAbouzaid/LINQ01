using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal static class IntExtension
    {
        public static int Reverse(this int number)
        {
            int result = 0, lastDigit;
            while (number > 0)
            {
                lastDigit = number % 10;
                result = result * 10 + lastDigit;
                number /= 10;
            }

            return result;
        }
    }
}
