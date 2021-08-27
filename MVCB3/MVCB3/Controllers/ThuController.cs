using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCB3.Models;

namespace MVCB3.Controllers
{
    public class ThuController : Controller
    {
        GiaiPhuongTrinh gpt = new GiaiPhuongTrinh();
        // GET: Thu
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Hi()
        {
            return View();
        }
        public ActionResult GPTB1()
        {
            return View();
        }
        [HttpPost]
        public ActionResult GPTB1(double HSa, double HSb)
        {
            double x = gpt.GiaiPhuongTrinhBacNhat(HSa, HSb);
            ViewBag.NghiemPT = x;
            return View();
        }
    }
}