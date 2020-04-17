using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ChoixResto.Models
{
    [Table("Resto")]
    public class Resto
    {
        public int RestoId { get; set; }
        public string Nom { get; set; }
        public string Telephone { get; set; }
    }
}