using ChoixResto.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace ChoixResto.Dal
{
    public class DalResto : DalAccess
    {
        public DalResto() :base()
        {
        }

        public List<Resto> GetRestos()
        {
            List<Resto> restos = null; 
            try
            {
                restos = db.Restos.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return restos;
        }

        public async Task<bool> Addresto(Resto resto)
        {
            bool IsCreated = false;
            try
            {
                db.Restos.Add(resto);
                await db.SaveChangesAsync();
                IsCreated = true;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return IsCreated;
        }
    }
}