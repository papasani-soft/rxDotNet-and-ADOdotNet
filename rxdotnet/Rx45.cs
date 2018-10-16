using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rxdotNet
{
    class Rx45
    {
        public static void Main(string[] args)
        {
            //var source = Observable.Interval(TimeSpan.FromSeconds(1))
            //.Take(5);
            //source.ForEach(i => Console.WriteLine("received {0} @ {1}", i, DateTime.Now));
            //Console.WriteLine("completed @ {0}", DateTime.Now);

            var source = Observable.Interval(TimeSpan.FromSeconds(1))
            .Take(5);
            source.Subscribe(i => Console.WriteLine("received {0} @ {1}", i, DateTime.Now));
            Console.WriteLine("completed @ {0}", DateTime.Now);


            Console.Read();
        }
    }
}
