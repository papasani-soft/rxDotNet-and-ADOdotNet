using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rxdotNet
{
    class Rx41
    {
        public static void Main(string[] args)
        {
            //var letters = Observable.Range(0, 3)
            //.Select(i => (char)(i + 65));
            //var index = -1;
            //var result = letters.Select(
            //c =>
            //{
            //    index++;
            //    return c;
            //});
            //result.Subscribe(
            //c => Console.WriteLine("Received {0} at index {1}", c, index),
            //() => Console.WriteLine("completed"));

            var source = Observable.Range(0, 3);
            var result = source.Select(
            (idx, value) => new
            {
                Index = idx,
                Letter = (char)(value + 65)
            });
            result.Subscribe(
            x => Console.WriteLine("Received {0} at index {1}", x.Letter, x.Index),
            () => Console.WriteLine("completed"));
            result.Subscribe(
            x => Console.WriteLine("Also received {0} at index {1}", x.Letter, x.Index),
            () => Console.WriteLine("2nd completed"));
            Console.Read();
        }
    }
}
