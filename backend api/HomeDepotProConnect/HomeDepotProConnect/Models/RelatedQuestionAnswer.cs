using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HomeDepotProConnect.Models
{
    public class RelatedQuestionAnswer
    {
        [Key]
        public int RelatedQuestionAnswerId { get; set; }

        public int QuestionAndAnswerId { get; set; }

        [MaxLength(200,ErrorMessage ="The related question cannot be more than 200 charcaters long")]
        [Display(Name ="Related Question")]
        public string RelatedQuestionMessage { get; set; }

        public virtual QuestionAndAnswers QuestionAndAnswers { get; set; }
    }
}