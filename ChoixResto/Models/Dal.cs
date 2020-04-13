using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChoixResto.Models
{
    public class Dal : IDal
    {
        private ApplicationDbContext bdd;

        public Dal()
        {
            bdd = new ApplicationDbContext();
        }

        public List<Resto> ObtientTousLesRestaurants()
        {
            return bdd.Restos.ToList();
        }

        public void Dispose()
        {
            bdd.Dispose();
        }
    }
}