using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HomeDepotProConnect.Models
{
    public class AreaOfExpertise
    {
        [Key]
        public int AreaOfExpertiseId { get; set; }

        [Display(Name ="Expert In")]
        [MaxLength(50,ErrorMessage ="The expertise name cannot be more than 50 characters")]
        public string AreaOfExpertiseName { get; set; }

        [Display(Name ="Expertise Description")]
        [MaxLength(300,ErrorMessage ="The description should be maximum 300 characters long")]
        public string AreaOfExpertiseDescription { get; set; }

        public virtual ICollection<Pros> Pros { get; set; }
    }
}