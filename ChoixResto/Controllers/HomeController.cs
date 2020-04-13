using ClassLibraryMR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace ChoixResto.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            DateTime date = DateTime.Today.AddDays(1).AddHours(11).AddMinutes(50);
            long test = JavaScriptDateConverter.Convert(date);

            ViewBag.DateButoire = test;
            return View();
        }
    }
}