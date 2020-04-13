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
        public VoteController()
        {
            this._dalVote = new DalVote();
        }
        // GET: Vote
        public ActionResult Index()
        {
            if(_dalVote.VerifierSiAVote(User.Identity.GetUserId(), (int)Session[Constantes.ID_SONDAGE]))
            {
                RedirectToAction("Index", "Home");
            }            
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }
    }
}