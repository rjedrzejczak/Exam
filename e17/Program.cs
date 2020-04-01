using System;

namespace e17
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculate(1.22f);
            Console.WriteLine("Hello World!");
        }
        
        public static void Calculate(float amount)
        {
            object amountRef = amount;

            int balance = (int) (float) amountRef;
            Console.WriteLine(balance);
        }
    }
}