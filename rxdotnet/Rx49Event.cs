using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rxdotNet
{
    class Rx49Event
    {
        public interface IEventSource<T>
        {
            event Action<T> OnNext;
        }
        public static void Main(string[] args)
        {
            var source = Observable.Interval(TimeSpan.FromSeconds(1))
            .Take(5);
            var result = source.ToEvent();
            result.OnNext += val => Console.WriteLine(val);
            Console.Read();
        }
    }
}
