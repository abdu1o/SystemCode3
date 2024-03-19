using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;


namespace SystemCode3
{
    public class Program
    {
        private static Generator generator = new Generator();

        static void Main(string[] args)
        {
            Console.WriteLine("Choose thread to start: \n[1] - prime \n[2] - fibonacci");
            string choose = Console.ReadLine();

            switch(choose)
            {
                case "1":
                    Console.Write("Enter start of range: ");
                    int startRange = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter end of range: ");
                    string endRange = Console.ReadLine();

                    int end = 0;

                    if (!string.IsNullOrEmpty(endRange))
                    {
                        end = Convert.ToInt32(endRange);
                    }

                    Thread primeThread = new Thread(() => generator.GeneratePrimes(startRange, end));
                    primeThread.Start();
                    primeThread.Join();

                    break;

                case "2":

                    Thread fibonacciThread = new Thread(() => generator.GenerateFibonacci(10));
                    fibonacciThread.Start();

                    Thread.Sleep(500);

                    fibonacciThread.Abort();
                    fibonacciThread.Join();

                    break;

                default:
                    Console.WriteLine("Try again");
                    Console.Clear();
                    Main(args);
                    break;
            }


            
            

            
            
        }
    }
}
