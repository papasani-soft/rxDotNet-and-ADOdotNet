using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rxdotNet
{
    class Rx40SelectMany2
    {
        private static IObservable<long> GetSubValues(long offset)
        {
            //Produce values [x*10, (x*10)+1, (x*10)+2] 4 seconds apart, but starting immediately.
            return Observable.Timer(TimeSpan.Zero, TimeSpan.FromSeconds(4))
            .Select(x => (offset * 10) + x)
            .Take(3);
        }
        public static void Main(string[] args)
        {
            Observable.Interval(TimeSpan.FromSeconds(3))
            .Select(i => i + 1) //Values start at 0, so add 1.
            .Take(3)            //We only want 3 values
            .SelectMany(GetSubValues) //project into child sequences
            .Dump("SelectMany");
            Console.Read();
        }
    }
}
