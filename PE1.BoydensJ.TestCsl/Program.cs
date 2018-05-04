using System;
using PE1.BoydensJ.Lib;
using System.Collections.Generic;
using System.Linq;

namespace PE1.BoydensJ.TestCsl
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var x = new ReeksService();
            IList<string> outputStrs = new List<string>();

            var allNumbers = x.GeefReeks(10, 20);
            outputStrs.Add("All numbers from min to max:");
            foreach(int a in allNumbers)
            {
                outputStrs.Add(a.ToString());
            }

            var evenNumbers = x.GeefReeksEven(10, 20);
            outputStrs.Add("All even from min to max:");
            foreach(int e in evenNumbers)
            {
                outputStrs.Add(e.ToString());
            }

            var primes = x.GeefPriemGetallen(10, 20);
            outputStrs.Add("All primes from min to max:");
            foreach (int e in primes)
            {
                outputStrs.Add(e.ToString());
            }

            Print(outputStrs);
            
            Console.ReadKey();
        }

        static void Print(IEnumerable<string> strs)
        {
            foreach (var s in strs)
            {
                Console.WriteLine(s);
            }
        }
    }
}
