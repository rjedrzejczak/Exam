using System;
using System.Threading.Tasks;

namespace Listing_1_9_shows_how_this_works
{
    class Program
    {
        static void Main(string[] args)
        {
            Task<int> t = Task.Run(() =>
            {
                return 42;
            });
            Console.WriteLine(t.Result);
        }
    }
}