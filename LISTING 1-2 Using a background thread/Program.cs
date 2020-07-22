using System;
using System.Threading;

namespace LISTING_1_2_Using_a_background_thread
{
    class Program
    {
        public static void Main()
        {
            Thread t = new Thread(ThreadMethod);
            t.IsBackground = true;
            t.Start();
        }
        
        public static void ThreadMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ThreadProc: {0}", i);
                Thread.Sleep(1000);
            }
        }
    }
}