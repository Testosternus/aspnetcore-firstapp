﻿using System;
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
        private ReeksService rs = new ReeksService();
        //GET: /Reeksen/
        public IActionResult Index()
        {
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

        [ActionName("IndexAlt")]
        public IActionResult Index(int a=100, int b=200)
        {
            StringBuilder sb = new StringBuilder();

            var allNumbers = rs.GeefReeks(a, b);
            sb.Append("Getallenreeks\r\n");
            foreach (int n in allNumbers)
                sb.Append($"{n.ToString()} \r\n");

            var evenNumbers = rs.GeefReeksEven(a, b);
            sb.Append("Even getallen\r\n");
            foreach (int e in evenNumbers)
                sb.Append($"{e.ToString()} \r\n");

            var primes = rs.GeefPriemGetallen(a, b);
            sb.Append("Priemgetallen\r\n");
            foreach (int p in primes)
                sb.Append($"{p.ToString()} \r\n");

            return Content(sb.ToString());
        }
    }
}
