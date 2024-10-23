using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelProjes.Models.Siniflar;

namespace TravelProjes.Controllers
{
    public class OtellerController : Controller
    {
        // GET: Oteller
        Context c = new Context();
        public ActionResult Index()
        {
            var otel = c.Otellers.ToList();
            return View(otel);
        }
    }
}