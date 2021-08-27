using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCB4.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetInfor()
        {
            return View();
        }
        [HttpPost]
        
        public ActionResult GetInfor (string HoTen, double Tuoi, double Lop)
        {
            //return View();
            ViewBag.hovaten = HoTen;
            ViewBag.tuoi = Tuoi;
            ViewBag.lop = Lop;
            return View();



        }
    }
}