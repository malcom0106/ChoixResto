﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ChoixResto.Models;

namespace ChoixResto.Controllers
{
    public class SondageController : Controller
    {
        // GET: Sondage
        public ActionResult Index()
        {
            return View();
        }
    }
}