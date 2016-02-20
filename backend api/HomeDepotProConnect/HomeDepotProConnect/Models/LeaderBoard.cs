using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HomeDepotProConnect.Models
{
    public class LeaderBoard
    {
        [Key]
        public int LeaderBoardId { get; set; }

        [Display(Name ="Pro Name")]
        public int ProsId { get; set; }

        [Display(Name ="Expert In")]
        public int AreaOfExpertiseId { get; set; }

        public virtual Pros Pros { get; set; }

        public virtual AreaOfExpertise AreaOfExpertise { get; set; }


    }
}