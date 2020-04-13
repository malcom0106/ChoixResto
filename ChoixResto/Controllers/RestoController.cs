using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ChoixResto.Dal;
using ChoixResto.Models;

namespace ChoixResto.Controllers
{
    [Authorize]
    public class RestoController : Controller
    {
        private DalResto _dalResto = null;
        public RestoController()
        {
            this._dalResto = new DalResto();
        }

        // GET: Restos
        public ActionResult Index()
        {
            List<Resto> restos = _dalResto.GetRestos();
            return View(restos);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Resto resto)
        {
            if (ModelState.IsValid)
            {
                if (_dalResto.Addresto(resto).Result)
                {
                    RedirectToAction("Index");
                }
                ViewBag.Erreur = "Une Erreur est apparu lors de la creation";
            }
            return View(resto);
        }
    }
}