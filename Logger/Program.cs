using System;

namespace Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseLogger logger = new Logger();
            logger.Log("Log started");
            logger.Log("Base: Log continuing");
            ((Logger)logger).LogCompleted();

        }
    }
}