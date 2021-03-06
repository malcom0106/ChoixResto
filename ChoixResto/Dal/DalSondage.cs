﻿using ChoixResto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChoixResto.Dal
{
    public class DalSondage : DalAccess
    {
        public DalSondage() : base()
        {
        }

    public int? VerifierSondageDuJour()
        {
            Sondage sondage = null;
            try
            {
                sondage = db.Sondages.Where(s => s.Date == DateTime.Today).FirstOrDefault();
                if (sondage == null)
                {
                    sondage = new Sondage();
                    sondage.Date = DateTime.Today;
                    db.Sondages.Add(sondage);
                    db.SaveChanges();                    
                }
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return sondage.SondageId;
        }
    }
}