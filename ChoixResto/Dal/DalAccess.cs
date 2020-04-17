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
            try
            {

            }
            catch (Exception ex)
            {
                throw ex;
            }
            this.db = new ApplicationDbContext();
        }
    }
}