using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemCode3
{
    public class Generator
    {
        private Inspector inspector = new Inspector();

        public void GeneratePrimes(int start, int end)
        {
            int current = start;

            while (true)
            {
                if (current >= end)
                {
                    break;
                }
                if (inspector.IsPrime(current))
                {
                    Console.WriteLine(current);
                }
                current++;
            }
        }

        public void GenerateFibonacci(int limit)
        {
            int currentNum = 0, nextNum = 1;
            Console.WriteLine("Fibonacci Series:");
            Console.WriteLine(currentNum);
            Console.WriteLine(nextNum);

            for (int i = 2; i < limit; i++)
            {
                int sum = currentNum + nextNum;
                Console.WriteLine(sum);

                currentNum = nextNum;
                nextNum = sum;
            }
        }
    }
}
