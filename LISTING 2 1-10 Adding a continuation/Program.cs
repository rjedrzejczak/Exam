﻿using System;
using System.Threading.Tasks;

namespace LISTING_1_10_Adding_a_continuation
{
    class Program
    {
        static void Main(string[] args)
        {
            Task<int> t = Task.Run(() =>
            {
                return 42;
            // Because of the object-oriented nature of the Task object, one thing you can do is add a
            // continuation task. This means that you want another operation to execute as soon as the Task
            // finishes.
            }).ContinueWith((i) =>
            {
                return i.Result * 2;
            });
            Console.WriteLine(t.Result);
        }
    }
}