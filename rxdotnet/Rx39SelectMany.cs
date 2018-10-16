using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rxdotNet
{
    class Rx39SelectMany
    {
        private static IEnumerable<int> GetSubValues(int offset)
        {
            yield return offset * 10;
            yield return (offset * 10) + 1;
            yield return (offset * 10) + 2;
        }
        public static void Main(string[] args)
        {
            var enumerableSource = new[] { 1, 2, 3 };
            var enumerableResult = enumerableSource.SelectMany(GetSubValues);
            foreach (var value in enumerableResult)
            {
                Console.WriteLine(value);
            }
            Console.Read();
        }
    }
}
