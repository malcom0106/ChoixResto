using ChoixResto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChoixResto.Dal
{
    public class DalAccess
    {
        protected ApplicationDbContext db;

        public DalAccess()
        {
            this.db = new ApplicationDbContext();
        }
    }
}