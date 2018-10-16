using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rxdotNet
{
    class Rx28SkipTake
    {
        public static void Main(string[]args)
        {
            Observable.Range(0, 10)
           // .Skip(3)
            .Take(3)
            .Subscribe(Console.WriteLine, () => Console.WriteLine("Completed"));
            Console.Read();
        }
    }
}
