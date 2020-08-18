using System;
using System.Threading;

namespace LISTING_1_7_Queuing_some_work_to_the_thread_pool
{
    class Program
    {
        static void Main(string[] args)
        {
            // A thread pool is created to reuse threads, similar to the way a database connection
            // pooling works. Instead of letting a thread die, you send it back to the pool where it can be
            // reused whenever a request comes in.
            
            // Queuing a work item to a thread pool can be useful, but it has its shortcomings. There is no
            // built-in way to know when the operation has finished and what the return value is.
            ThreadPool.QueueUserWorkItem((s) =>
            {
                Console.WriteLine("Working on a thread from threadpool");
            });
            Console.ReadLine();
        }
    }
}