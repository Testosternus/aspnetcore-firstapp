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
        [HttpGet]
        public IActionResult Index()
        {
            ReeksService rs = new ReeksService();
            StringBuilder sb = new StringBuilder();

            var allNumbers = rs.GeefReeks(10, 20);
            sb.Append("All numbers from min to max:");
            foreach (int n in allNumbers)
                sb.Append(n.ToString());

            var evenNumbers = rs.GeefReeksEven(10, 20);
            sb.Append("All even from min to max:");
            foreach (int e in evenNumbers)
                sb.Append(e.ToString());

            var primes = rs.GeefPriemGetallen(10, 20);
            sb.Append("All primes from min to max:");
            foreach (int p in primes)
                sb.Append(p.ToString());

            return Content(sb.ToString());
        }
    }
}
