using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rxdotNet
{
    class Rx19ObsGenerate
    {
        public static IObservable<int> Range(int start, int count)
        {
            var max = start + count;
            return Observable.Generate(
            start,
            value => value < max,
            value => value + 1,
            value => value);
        }
        public static void Main(string[]args)
        {
            var observe=Range(1,10);
            observe.Subscribe(Console.WriteLine);
            Console.Read();
        }
    }
}
