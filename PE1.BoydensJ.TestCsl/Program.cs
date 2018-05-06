using System;
using PE1.BoydensJ.Lib;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PE1.BoydensJ.TestCsl
{
    public class Program
    {
        static ReeksService x = new ReeksService();
        static TekstService y = new TekstService();
        public static void Main(string[] args)
        {

            Task getNormal = StringConv("Hello Async!", TekstMode.Normal);
            getNormal.Wait();

            Task getReverse = StringConv("Hello Async!", TekstMode.Reverse);
            getReverse.Wait();

            Task getAscii = StringConv("Hello Async!", TekstMode.Ascii);
            getAscii.Wait();

            IList<string> outputStrs = new List<string>();

            var allNumbers = x.GeefReeks(10, 20);
            outputStrs.Add("All numbers from min to max:");
            foreach (int a in allNumbers)
                outputStrs.Add(a.ToString());

            var evenNumbers = x.GeefReeksEven(10, 20);
            outputStrs.Add("All even from min to max:");
            foreach (int e in evenNumbers)
                outputStrs.Add(e.ToString());

            var primes = x.GeefPriemGetallen(10, 20);
            outputStrs.Add("All primes from min to max:");
            foreach (int e in primes)
                outputStrs.Add(e.ToString());

            Print(outputStrs);

            Console.ReadKey();
        }

        static void Print(IEnumerable<string> strs)
        {
            foreach (var s in strs)
                Console.WriteLine(s);
        }

        static async Task StringConv(string input, TekstMode m)
        {
            var resp = await y.GetTekst(input, m);
            Console.WriteLine($"Converting: {input} \r\n {resp}");
        }
    }
}
