using System;
using System.Threading;

namespace LISTING_1_3_Using_the_ParameterizedThreadStart
{
    class Program
    {
        // The Thread constructor has another overload that takes an instance of a ParameterizedThreadStart delegate. This overload can be used if you want to pass some data through
        // the start method of your thread to your worker method.
        public static void ThreadMethod(object o)
        {
            for (int i = 0; i < (int)o; i++)
            {
                Console.WriteLine("ThreadProc: {0}", i);
                Thread.Sleep(0);
            }
        }
        public static void Main()
        {
            Thread t = new Thread(new ParameterizedThreadStart(ThreadMethod));
            t.Start(5);
            t.Join();
        }
    }
}