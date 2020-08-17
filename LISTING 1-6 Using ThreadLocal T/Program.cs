using System;
using System.Threading;

namespace LISTING_1_6_Using_ThreadLocal_T
{
    class Program
    {
        // If you want to use local data in a thread and initialize it for each thread, you can use the
        // ThreadLocal<T> class.
        
        public static ThreadLocal<int> _field = new ThreadLocal<int>(() => 
        { 
            return Thread.CurrentThread.ManagedThreadId; 
        });
        public static void Main()
        {
            new Thread(() =>
            { 
                for(int x = 0; x < _field.Value; x++)
                {
                    Console.WriteLine("Thread A: {0}", x);
                }
            }).Start();
            new Thread(() =>
            {
                for (int x = 0; x < _field.Value; x++)
                {
                    Console.WriteLine("Thread B: {0}", x);
                }
            }).Start();
            Console.ReadKey();
        }
    }
}