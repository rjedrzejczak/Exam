using System;
using System.Threading.Tasks;

namespace LISTING_2_1_12_Attaching_child_tasks_to_a_parent_task
{
    class Program
    {
        static void Main(string[] args)
        {
            // Next to continuation Tasks, a Task can also have several child Tasks. The parent Task finishes when all the child tasks are ready.
            Task<Int32[]> parent = Task.Run(() =>
            {
                var results = new Int32[3];
                new Task(() => results[0] = 0, 
                    TaskCreationOptions.AttachedToParent).Start();
                new Task(() => results[1] = 1, 
                    TaskCreationOptions.AttachedToParent).Start();
                new Task(() => results[2] = 2, 
                    TaskCreationOptions.AttachedToParent).Start();
                return results;
            });
            
            var finalTask = parent.ContinueWith(parentTask => {
                foreach (int i in parentTask.Result)
                {
                    Console.WriteLine(i);
                }
            });
            
            finalTask.Wait();
        }
    }
}