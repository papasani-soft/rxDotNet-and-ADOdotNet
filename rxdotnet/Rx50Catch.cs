using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading.Tasks;

namespace rxdotNet
{
    class Rx50Catch
    {
        public static void Main(string[] args)
        {
            //var source = new Subject<int>();
            //var result = source.Catch<int, TimeoutException>(tx => Observable.Return(-1));
            //result.Dump("Catch");
            //source.OnNext(1);
            //source.OnNext(2);
            //source.OnError(new ArgumentException("Fail!"));

            //var source = new Subject<int>();
            //var result = source.Finally(() => Console.WriteLine("Finally action ran"));
            //result.Dump("Finally");
            //source.OnNext(1);
            //source.OnNext(2);
            //source.OnNext(3);
            //source.OnCompleted();

            var source = new Subject<int>();
            var result = source.Finally(() => Console.WriteLine("Finally"));
            var subscription = result.Subscribe(
            Console.WriteLine,
            Console.WriteLine,
            () => Console.WriteLine("Completed"));
            source.OnNext(1);
            source.OnNext(2);
            source.OnNext(3);
            subscription.Dispose();

            Console.Read();
        }
    }
}
