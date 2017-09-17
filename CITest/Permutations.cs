using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CITest
{
    public class Permutations
    {
        public static long Compute(long n)
        {
            var result = n;
            if (n>1)
            {
                result = result * Compute(result - 1);
            }
            return result;
        }
    }
}
