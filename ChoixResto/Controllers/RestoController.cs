using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ChoixResto.Models;

namespace ChoixResto.Controllers
{
    public class RestoController : Controller
    {
        // GET: Restos
        public ActionResult Index()
        {
            return View();
        }


    }
}