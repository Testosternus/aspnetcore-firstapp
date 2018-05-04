using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

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
            //negative primes are useless, so not accounting for them
            IEnumerable<int> reeks = Enumerable.Range(min, count)
                                                .Where(x => Enumerable.Range(2, (int)Math.Ceiling(Math.Sqrt(x)))
                                                .All(y => x % y != 0));
            //.Concat(new int[] { 2, 3 })
            //.OrderBy(x => x);

            foreach (int n in reeks)
                yield return n;
        }

        private static int calcCount(int min, int max) => (max - min) + 1;

    }

    public enum TekstMode { Normal, Reverse, Ascii }

    public class TekstService
    {
        private readonly HttpClient httpClient = new HttpClient();

        public async Task<string> GetTekst(string input, TekstMode m)
        {
            string outP = "";
            switch (m)
            {
                case TekstMode.Normal:
                    outP =  input;
                    break;
                case TekstMode.Reverse:
                    outP = new string(input.ToCharArray().Reverse().ToArray());
                    break;
                case TekstMode.Ascii:
                    var resp = await httpClient.GetStringAsync($"http://artii.herokuapp.com/make?text={input}");
                    outP =  resp.ToString();
                    break;
                default:
                    break;
            }

            return outP;
        }
    }
}
