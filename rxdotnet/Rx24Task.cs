using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Threading.Tasks;
using System.Text;
using System.Threading.Tasks;

namespace rxdotNet
{
    class Rx24Task
    {
        public static void Main(string[]args)
        {
            var t = Task.Factory.StartNew(() => "Test");
            var source = t.ToObservable();
            source.Subscribe(
            Console.WriteLine,
            () => Console.WriteLine("completed"));
            Console.Read();
        }
    }
}
