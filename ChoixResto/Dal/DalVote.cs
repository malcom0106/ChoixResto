using ChoixResto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChoixResto.Dal
{
    public class DalVote : DalAccess
    {
        public DalVote() : base()
        {
        }

        public void test()
        {
            Vote vote = db.Votes.FirstOrDefault();

        }
    }
}