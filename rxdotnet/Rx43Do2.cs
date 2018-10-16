using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rxdotNet
{
    class Rx43Do2
    {
        private static IObservable<long> GetNumbers()
        {
            return Observable.Interval(TimeSpan.FromMilliseconds(250))
            .Do(i => Console.WriteLine("pushing {0} from GetNumbers", i));
        }
        public static void Main(string[] args)
        {
            var source = GetNumbers();
            var result = source.Where(i => i % 3 == 0)
            .Take(3)
            .Select(i => (char)(i + 65));
            result.Subscribe(
            Console.WriteLine,
            () => Console.WriteLine("completed"));
            Console.Read();
        }
    }
}
