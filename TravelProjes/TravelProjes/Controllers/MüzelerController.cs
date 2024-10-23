using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelProjes.Models.Siniflar;

namespace TravelProjes.Controllers
{
    public class MüzelerController : Controller
    {
        // GET: Müzeler
        Context c = new Context();
        public ActionResult Index()
        {
            var müze = c.Müzelers.ToList();
            return View(müze);
        }
    }
}