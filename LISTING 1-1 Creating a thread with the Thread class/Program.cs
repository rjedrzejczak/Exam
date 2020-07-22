using System;
using System.Threading;

namespace LISTING_1_1_Creating_a_thread_with_the_Thread_class
{
    class Program
    {
        public static void Main()
        {
            var t = new Thread(ThreadMethod);
            t.Start();
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Main thread: Do some work.");
                Thread.Sleep(0);
            }
            t.Join();
        }

        private static void ThreadMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ThreadProc: {0}", i);
                Thread.Sleep(0);
            }
        }
    }
}