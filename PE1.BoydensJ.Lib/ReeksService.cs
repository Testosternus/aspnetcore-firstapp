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
            IList<int> reeks = new List<int>();
            for (int i = min; i <= max; i++)
            {
                reeks.Add(i);
            }

            foreach (int n in reeks)
                yield return n;
        }
    }
}
