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
                // Why the Thread.Sleep(0)? It is used to signal to Windows that this thread is finished. Instead of waiting for the whole time-slice of the thread to finish, it will immediately switch to
                // another thread.
            }
            t.Join();
            // The Thread.Join
            // method is called on the main thread to let it wait until the other thread finishes.
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