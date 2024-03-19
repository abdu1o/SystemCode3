using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemCode3
{
    public class Inspector
    {
        public bool IsPrime(int num)
        {
            if (num <= 1)
            {
                return false;
            }
            if (num <= 3)
            {
                return true;
            }

            if (num % 2 == 0 || num % 3 == 0)
            {
                return false;
            }
            int i = 5;

            while (i * i <= num)
            {
                if (num % i == 0 || num % (i + 2) == 0)
                {
                    return false;
                }

                i += 6;
            }

            return true;
        }

    }
}
