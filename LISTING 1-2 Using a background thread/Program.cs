using System;
using System.Threading;

namespace LISTING_1_2_Using_a_background_thread
{
    class Program
    {
        // Another thing that’s important to know about threads is the difference between foreground and background threads. Foreground threads can be used to keep an application
        // alive. Only when all foreground threads end does the common language runtime (CLR) shut
        // down your application. Background threads are then terminated.
        public static void Main()
        {
            var t = new Thread(ThreadMethod)
            {
                IsBackground = true
            };
            
            t.Start();
        }

        private static void ThreadMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ThreadProc: {0}", i);
                Thread.Sleep(1000);
            }
        }
    }
}