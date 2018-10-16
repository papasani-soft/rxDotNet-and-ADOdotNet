using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using System.Text;
using System.Threading.Tasks;

namespace rxdotNet
{
    class Rx48Totask
    {
        public static void Main(string[] args)
        {
            var source = Observable.Interval(TimeSpan.FromSeconds(1))
            .Take(5);
            var result = source.ToTask(); //Will arrive in 5 seconds. 
            Console.WriteLine(result.Result);

            Console.Read();
          
        }
    }
}
