using System;
using System.Threading.Tasks;

namespace Listing_1_8_shows_how_to_start_a_new_Task_and_wait_until_its_finished
{
    class Program
    {
        static void Main(string[] args)
        {
            // A task scheduler is responsible for starting the Task and managing it. By default, the Task
            // scheduler uses threads from the thread pool to execute the Task.
            Task t = Task.Run(() =>
            {
                for (int x = 0; x < 100; x++)
                {
                    Console.Write('*');
                }
            });
            
            // Calling Wait is equivalent to
            // calling Join on a thread. It waits till the Task is finished before exiting the application.
            t.Wait();
        }
    }
}