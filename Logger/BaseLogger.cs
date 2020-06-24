using System;

namespace Logger
{
    public abstract class BaseLogger
    {
        public virtual void Log(string message)
        {
            Console.WriteLine("Base" + message);
        }

        public void LogCompleted()
        {
            Console.WriteLine("Completed");
        }
    }

    public class Logger : BaseLogger
    {
        public override void Log(string message)
        {
            Console.WriteLine(message);
        }

        public new void LogCompleted()
        {
            Console.WriteLine("Finished");
        }

    }
}