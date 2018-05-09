using System;
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
        //GET: /Teksten/
        public IActionResult Index()
        {
            StringBuilder sb = new StringBuilder();
            TekstService ts = new TekstService();

            var getNormal = ts.GetTekst("Jonathan Boydens", TekstMode.Normal);
            getNormal.Wait();
            return Content(getNormal.ToString());
        }
    }
}