using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ChoixResto.Models
{
    [Table("Vote")]
    public class Vote
    {
        public int VoteId { get; set; }

        public int RestoId { get; set; }
        [ForeignKey("RestoId")]
        public Resto Resto { get; set; }

        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public ApplicationUser Utilisateur { get; set; }

        public int SondageId { get; set; }
        [ForeignKey("SondageId")]
        public Sondage Sondage { get; set; }
    }
}