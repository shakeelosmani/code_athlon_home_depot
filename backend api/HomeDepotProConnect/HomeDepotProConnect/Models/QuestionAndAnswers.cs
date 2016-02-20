using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HomeDepotProConnect.Models
{
    public class QuestionAndAnswers
    {
        [Key]
        public int QuestionAndAnswersId { get; set; }

        [Display(Name ="Pro Name")]
        public int ProsId { get; set; }

        [Display(Name ="Question")]
        [MaxLength(200, ErrorMessage ="The question cannot be more than 200 characters long")]
        public string Question { get; set; }

        [Display(Name ="Answer")]
        [MaxLength(500,ErrorMessage ="The answer cannot be more than 500 characters long")]
        public string Answer { get; set; }

        [Display(Name ="Related to")]
        public int AreaOfExpertiseId { get; set; }

        [Display(Name ="Rating")]
        public int UserRating { get; set; }

        public int UserId { get; set; }

        public virtual Pros Pros { get; set; }

        public virtual AreaOfExpertise AreaOfExpertise { get; set; }

        public virtual Users Users { get; set; }

        public virtual ICollection<RelatedQuestionAnswer> RelatedQuestionAndAnswer { get; set; }
    }
}