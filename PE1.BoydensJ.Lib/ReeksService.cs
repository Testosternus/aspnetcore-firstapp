using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PE1.BoydensJ.Lib
{
    public class ReeksService
    {
        public IEnumerable<int> GeefReeks(int min, int max)
        {
            int count = calcCount(min, max);
            IEnumerable<int> reeks = Enumerable.Range(min, count).Select(x => x);

            foreach (int n in reeks)
                yield return n;
        }

        public IEnumerable<int> GeefReeksEven(int min, int max)
        {
            int count = calcCount(min, max);
            IEnumerable<int> reeks = Enumerable.Range(min, count).Where(x => x % 2 == 0);

            foreach (int n in reeks)
                yield return n;
        }

        public IEnumerable<int> GeefPriemGetallen(int min, int max)
        {
            int count = calcCount(min, max);
            IEnumerable<int> reeks = Enumerable.Range(min, count).Where(x => Enumerable.Range(2, x - 2).All(y => x % y != 0));

            foreach (int n in reeks)
                yield return n;
        }
        
        private static int calcCount(int min, int max)
        {
            return (max - min) + 1;
        }
    }
}
