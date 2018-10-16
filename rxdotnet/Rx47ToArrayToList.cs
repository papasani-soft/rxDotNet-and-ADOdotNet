using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rxdotNet
{
    class Rx47ToArrayToList
    {
        public static void Main(string[] args)
        {
            var period = TimeSpan.FromMilliseconds(200);
            var source = Observable.Timer(TimeSpan.Zero, period).Take(5);
            var result = source.ToArray();
            result.Subscribe(
            arr => {
                Console.WriteLine("Received array");
                foreach (var value in arr)
                {
                    Console.WriteLine(value);
                }
            },
            () => Console.WriteLine("Completed")
            );
            Console.WriteLine("Subscribed");
            Console.Read();
        }
    }
}
