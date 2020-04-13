using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ChoixResto.Dal;
using ChoixResto.Models;
using ChoixResto.Utilities;
using Microsoft.AspNet.Identity;

namespace ChoixResto.Controllers
{
    public class VoteController : Controller
    {
        private DalVote _dalVote = null;
        private List<Resto> _restos = null;
        public VoteController()
        {
            this._dalVote = new DalVote();
            DalResto dalResto = new DalResto();             
            this._restos = dalResto.GetRestos();
        }

        // GET: Vote
        public ActionResult Index()
        {
            if(_dalVote.VerifierSiAVote(User.Identity.GetUserId(), (int)Session[Constantes.ID_SONDAGE]))
            {
                return RedirectToAction("Index", "Home");
            }
            
            ViewBag.Restos = _restos;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(FormCollection formCollection)
        {
            try
            {
                int restoId = Convert.ToInt32(formCollection["MonVote"]);
                if(_dalVote.AVote(User.Identity.GetUserId(), (int)Session[Constantes.ID_SONDAGE], restoId))
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            catch(Exception ex)
            {
                string message = ex.Message;
            }
            ViewBag.Erreur = "Echec du vote";
            ViewBag.Restos = _restos;
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }
    }
}