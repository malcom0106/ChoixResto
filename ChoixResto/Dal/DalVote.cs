using ChoixResto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity;

namespace ChoixResto.Dal
{
    public class DalVote : DalAccess
    {
        public DalVote() : base()
        {
        }

        public bool VerifierSiAVote(string UserId, int SondageId)
        {
            bool AVote = false;
            Vote vote = null;
            try
            {
                vote = db.Votes.Where(s => s.SondageId == SondageId && s.Utilisateur.Id == UserId).FirstOrDefault();
                if (vote != null)
                {
                    AVote = true;
                }
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return AVote;
        }

        public bool AVote(string UserId, int SondageId, int RestoId)
        {
            bool Avote = false;
            Vote vote = null;
            try
            {
                vote = db.Votes.Where(s => s.SondageId == SondageId && s.Utilisateur.Id == UserId).FirstOrDefault();
                if (vote == null)
                {
                    vote = new Vote();
                    vote.SondageId = SondageId;
                    vote.RestoId = RestoId;
                    vote.UserId = UserId;
                    db.Votes.Add(vote);
                    db.SaveChanges();
                    Avote = true;
                }
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }


            return Avote;
        }
    }
}