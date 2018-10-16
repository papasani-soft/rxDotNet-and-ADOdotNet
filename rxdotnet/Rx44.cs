using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading.Tasks;

namespace rxdotNet
{
    public class UltraLeakyLetterRepo
    {
        public ReplaySubject<string> Letters { get; set; }
        public UltraLeakyLetterRepo()
        {
            Letters = new ReplaySubject<string>();
            Letters.OnNext("A");
            Letters.OnNext("B");
            Letters.OnNext("C");
        }
    }
    public class LeakyLetterRepo
    {
        private readonly ReplaySubject<string> _letters;
        public LeakyLetterRepo()
        {
            _letters = new ReplaySubject<string>();
            _letters.OnNext("A");
            _letters.OnNext("B");
            _letters.OnNext("C");
        }
        public ReplaySubject<string> Letters
        {
            get { return _letters; }
        }
    }
   
    class Rx44
    {
        // public IObservable<string> Letters
        //    {
        //        get { return _letters; }
        //    }
        //public static void Main(string[] args)
        //{
        //    var repo = new ObscuredLeakinessLetterRepo();
        //    var good = repo.GetLetters();
        //    var evil = repo.GetLetters();
        //    good.Subscribe(
        //    Console.WriteLine);
            //Be naughty
          //  var asSubject = evil as ISubject<string>;
            //if (asSubject != null)
            //{
            //    //So naughty, 1 is not a letter!
            //    asSubject.OnNext("1");
            //}
            //else
            //{
            //    Console.WriteLine("could not sabotage");
            //}
        }
   // }
}
