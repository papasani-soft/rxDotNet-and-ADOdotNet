using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading.Tasks;

namespace rxdotNet
{
    public static class SampleExtentions
    {
        public static void Dump<T>(this IObservable<T> source, string name)
        {
            source.Subscribe(
            i => Console.WriteLine("{0}-->{1}", name, i),
            ex => Console.WriteLine("{0} failed-->{1}", name, ex.Message),
            () => Console.WriteLine("{0} completed", name));
        }
    }
    class Rx38Count
    {
        public static void Main(string[]args)
        {
            //var numbers = Observable.Range(0, 3);
            //numbers.Dump("numbers");
            //numbers.Count().Dump("count");

            //var numbers = new Subject<int>();
            //numbers.Dump("numbers");
            //numbers.Min().Dump("Min");
            //numbers.Average().Dump("Average");
            //numbers.OnNext(1);
            //numbers.OnNext(2);
            //numbers.OnNext(3);
            //numbers.OnCompleted();

            //var numbers = new Subject<int>();
            //numbers.Dump("numbers");
            //numbers.Min().Dump("Min");
            //numbers.Average().Dump("Average");
            //numbers.OnNext(1);
            //numbers.OnNext(2);
            //numbers.OnNext(3);
            //numbers.OnCompleted();

            //var numbers = new Subject<int>();
            //var scan = numbers.Scan(0, (acc, current) => acc + current);
            //numbers.Dump("numbers");
            //scan.Dump("scan");
            //numbers.OnNext(1);
            //numbers.OnNext(2);
            //numbers.OnNext(3);
            //numbers.OnCompleted();

            //var source = Observable.Interval(TimeSpan.FromSeconds(0.1)).Take(10);
            //var group = source.GroupBy(i => i % 3);
            //group.SelectMany(
            //grp =>
            //grp.Max()
            //.Select(value => new { grp.Key, value }))
            //.Dump("group");

            //var source = Observable.Range(0, 5);
            //source.Select(i => i + 3)
            //.Dump("+3");
            //

            //var objects = new Subject<object>();
            //objects.Cast<int>().Dump("cast");
            //objects.OnNext(1);
            //objects.OnNext(2);
            //objects.OnNext(3);
            //objects.OnCompleted();

            //var objects = new Subject<object>();
            //objects.Cast<int>().Dump("cast");
            //objects.OnNext(1);
            //objects.OnNext(2);
            //objects.OnNext("3");//Fail

            //var objects = new Subject<object>();
            //objects.OfType<int>().Dump("OfType");
            //objects.OnNext(1);
            //objects.OnNext(2);
            //objects.OnNext("3");//Ignored
            //objects.OnNext(4);
            //objects.OnCompleted();

            //Observable.Interval(TimeSpan.FromSeconds(1))
            //.Take(3)
            //.Timestamp()
            //.Dump("TimeStamp");

            //var source = new Subject<int>();
            //source.Materialize()
            //.Dump("Materialize");
            //source.OnNext(1);
            //source.OnNext(2);
            //source.OnNext(3);
            //source.OnError(new Exception("Fail?"));

            //Observable.Return(3)
            //.SelectMany(i => Observable.Range(1, i))
            //.Dump("SelectMany");

            Func<int, char> letter = i => (char)(i + 64);
            Observable.Range(1, 30)
            .SelectMany(
            i =>
            {
                if (0 < i && i < 27)
                {
                    return Observable.Return(letter(i));
                }
                else
                {
                    return Observable.Empty<char>();
                }
            })
            .Dump("SelectMany");
            Console.Read();
        }
    }
}
