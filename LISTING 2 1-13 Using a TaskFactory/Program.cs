using System;
using System.Threading.Tasks;

namespace LISTING_1_13_Using_a_TaskFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            // Shows how you can simplify the previous example with a factory.
            Task<Int32[]> parent = Task.Run(() =>
            {
                var results = new Int32[3];
                
                TaskFactory taskFactory = new TaskFactory(TaskCreationOptions.AttachedToParent, TaskContinuationOptions.ExecuteSynchronously);
                taskFactory.StartNew(() => results[0] = 0);
                taskFactory.StartNew(() => results[1] = 1);
                taskFactory.StartNew(() => results[2] = 2);
                
                return results;
            });

            var finalTask = parent.ContinueWith(parentTask =>
            {
                foreach (var i in parentTask.Result)
                {
                    Console.WriteLine(i);
                }
            });

            finalTask.Wait();
        }
    }
}