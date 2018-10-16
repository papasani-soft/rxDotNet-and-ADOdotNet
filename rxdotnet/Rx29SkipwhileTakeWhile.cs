﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading.Tasks;

namespace rxdotNet
{
    class Rx29SkipwhileTakeWhile
    {
        public static void Main(string[]args)
        {
            var subject = new Subject<int>();
            subject
            //.SkipWhile(i => i < 4)
            .TakeWhile(i => i < 4)
            .Subscribe(Console.WriteLine, () => Console.WriteLine("Completed"));
            subject.OnNext(1);
            subject.OnNext(2);
            subject.OnNext(5);
            subject.OnNext(3);
            subject.OnNext(4);
            subject.OnNext(3);
            subject.OnNext(2);
          
            subject.OnNext(1);
            subject.OnNext(0);
            subject.OnCompleted();
            Console.Read();
        }
    }
}
