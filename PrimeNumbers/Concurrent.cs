using System;
using System.Diagnostics;
using System.Threading;
using Exercise;

namespace Concurrent
{
    public class ConPrimeNumbers : PrimeNumbers
    {
        public ConPrimeNumbers()
        {
        }

        public static void printPrimes(int lower, int upper)
        {
            Boolean isPrime = true;

            if (lower > upper)
            {
                Console.WriteLine("invalid inputs");
                return;
            }

            for (int n = lower; n <= upper; n++)
            {
                if (n % 1000 == 0) // This condition fakes an IO operation.
                    Thread.Sleep(100);

                isPrime = true; // assume n is a prime number

                for (int i = 2; i < n && isPrime; i++)
                    if (n % i == 0)
                        isPrime = false; // our assumption was not correct

                if (isPrime) 
                    Console.WriteLine("{0}",n); // report prime number if our assumption was correct
            }

        }
            
        /// <summary>
        /// This method 
        /// </summary>
        /// <param name="m"> is the minimum number</param>
        /// <param name="M"> is the maximum number</param>
        /// <param name="nt"> is the number of threads. For simplicity assume two.</param>
        public void runConcurrent(int m, int M)
        {
            int fhm = m;
            int fhM = M / 2;
            
            int lhm = M / 2 + 1;
            int lhM = M;
            
            // Todo 1: Create two threads, define their segments and start them. Join them all to have all the work done.
            Thread t1 = new Thread(() => printPrimes(fhm, fhM));
            Thread t2 = new Thread(() => printPrimes(lhm, lhM));
            
            Stopwatch sw = new Stopwatch();
            sw.Start();

            t1.Start();
            t2.Start();

            t1.Join();
            t2.Join();
            
            sw.Stop();

            Console.WriteLine("Time for concurrent version is {0} msec,", sw.ElapsedMilliseconds);
        }

    }
}
