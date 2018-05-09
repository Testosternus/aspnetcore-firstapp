using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text;
using PE1.BoydensJ.Lib;

namespace PE1.BoydensJ.Web.Controllers
{
    public class ReeksenController : Controller
    {
        //GET: /Reeksen/
        public IActionResult Index()
        {
            ReeksService rs = new ReeksService();
            StringBuilder sb = new StringBuilder();

            var allNumbers = rs.GeefReeks(10, 20);
            sb.Append("Getallenreeks\r\n");
            foreach (int n in allNumbers)
                sb.Append($"{n.ToString()} \r\n");

            var evenNumbers = rs.GeefReeksEven(10, 20);
            sb.Append("Even getallen\r\n");
            foreach (int e in evenNumbers)
                sb.Append($"{e.ToString()} \r\n");

            var primes = rs.GeefPriemGetallen(10, 20);
            sb.Append("Priemgetallen\r\n");
            foreach (int p in primes)
                sb.Append($"{p.ToString()} \r\n");

            return Content(sb.ToString());
        }
    }
}
