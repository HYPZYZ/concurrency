using System;
using System.Diagnostics;
using System.Threading;
using Exercise;

namespace Program
{
    class Synchronization
    {
        static void Main(string[] args)
        {
            int until = 10000, times = 10, wt = 2000;
            SynchronizationExamples examples = new SynchronizationExamples();
            Console.WriteLine("Example:" + examples.GetType().Name);

            var sw = new Stopwatch();
            
            Thread.Sleep(wt);
            // todo 1: uncomment this and check the final result.
            sw.Start();
            examples.countMultipleTimes(times,until);
            sw.Stop();
            Console.WriteLine(sw.Elapsed);
            
            Thread.Sleep(wt);
            // todo 2: uncomment this and check the final result. Is the final result reliable? Try to experiment several times.
            // Why the result is different in various scenarios? Check the implementation.
            sw.Restart();
            examples.countMultipleTimesConc(times, until);
            sw.Stop();
            Console.WriteLine(sw.Elapsed);
            
            Thread.Sleep(wt);
            // todo 3: uncomment this and check the final result. Is this result reliable? Why? Check the implementation.
            sw.Restart();
            examples.countMultipleTimesConcTSafe(times, until);
            sw.Stop();
            Console.WriteLine(sw.Elapsed);
        }
    }
}
