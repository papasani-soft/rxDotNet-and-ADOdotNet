using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rxdotNet
{
    class Rx22ObsTimer2
    {
        //public static IObservable<long> Timer(TimeSpan dueTime)
        //{
        //    return Observable.Generate(
        //    0l,
        //    i => i < 1,
        //    i => i + 1,
        //    i => i,
        //    i => dueTime);
        //}
        public static IObservable<long> Timer(TimeSpan dueTime, TimeSpan period)
        {
            return Observable.Generate(
            0l,
            i => true,
            i => i + 1,
            i => i,
            i => i == 0 ? dueTime : period);
        }
        //public static IObservable<long> Interval(TimeSpan period)
        //{
        //    return Observable.Generate(
        //    0l,
        //    i => true,
        //    i => i + 1,
        //    i => i,
        //    i => period);
        //}
        public static void Main(string[]args)
        {
      //     var t= Timer(2,5);
          // var t2= Timer(2);

        }
    }
}
