﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text;
using PE1.BoydensJ.Lib;

namespace PE1.BoydensJ.Web.Controllers
{
    public class TekstenController : Controller
    {
        private TekstService ts = new TekstService();
        //GET: /Texts/
        public IActionResult Index()
        {
            StringBuilder sb = new StringBuilder();
            
            IList<Task<string>> tasks = new List<Task<string>>();
            tasks.Add(ts.GetTekst("Jonathan Boydens", TekstMode.Normal));
            tasks.Add(ts.GetTekst("Jonathan Boydens", TekstMode.Reverse));
            tasks.Add(ts.GetTekst("Jonathan Boydens", TekstMode.Ascii));

            Task.WaitAll(tasks.ToArray());

            foreach (var task in tasks)
                sb.Append($"{task.Result} \r\n");
            return Content(sb.ToString());
        }
    }
}