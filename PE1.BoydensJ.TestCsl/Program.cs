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
            IList<string> outputStrs = new List<string>();

            var x = new ReeksService();
            var allNumbers = x.GeefReeks(10, 20);
            foreach(int v in allNumbers)
            {
                outputStrs.Add(v.ToString());
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
