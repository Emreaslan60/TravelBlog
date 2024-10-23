using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelProjes.Models.Siniflar;

namespace TravelProjes.Controllers
{
    public class İletişimController : Controller
    {
        // GET: İletişim
        Context c = new Context();
        public ActionResult Index()
        {
            var ilet = c.İletişims.ToList();
            return View(ilet);
        }
    }
}