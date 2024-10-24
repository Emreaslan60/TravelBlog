﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelProjes.Models.Siniflar;
using TravelProjes.Controllers;

namespace TravelProjes.Controllers
{
    public class DefaultController : Controller
    {
        Context c = new Context();
        // GET: Default
        public ActionResult Index()
        {

            var degerler = c.Blogs.Take(8).ToList();
            return View(degerler);
        }
        public ActionResult About()
        {
            return View();
        }

        public PartialViewResult Partial3()
        {
            var deger = c.Blogs.Take(10).ToList();
            return PartialView(deger);
        }

        public PartialViewResult Partial4()
        {
            var deger = c.Blogs.Take(3).ToList();
            return PartialView(deger);
        }

        public PartialViewResult Partial5()
        {
            var deger = c.Blogs.Take(3).OrderByDescending(x => x.ID).ToList();   /*ID sine göre z den a ya doğru sırala dedik*/
            return PartialView(deger);
        }
    }
}