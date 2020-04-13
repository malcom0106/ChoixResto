using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ChoixResto.Models
{
    public class Vote
    {
        public int VoteId { get; set; }
        public Resto Resto { get; set; }
        public ApplicationUser Utilisateur { get; set; }
        public int SondageId { get; set; }
        [ForeignKey("SondageId")]
        public Sondage Sondage { get; set; }
    }
}