using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HomeDepotProConnect.Models
{
    public class Pros
    {
        [Key]
        public int ProsId { get; set; }

        [Display(Name = "First Name")]
        [MaxLength(30, ErrorMessage = "The first name must be maximum 30 characters long")]
        public string FirstName { get; set; }

        [Display(Name ="Last Name")]
        [MaxLength(30, ErrorMessage = "The first name must be maximum 30 characters long")]
        public string LastName { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name ="Device")]
        public int DeviceId { get; set; }

        [Display(Name ="Additional device")]
        public int AdditionalDeviceId { get; set; }

        [Display(Name ="Available From")]
        [DataType(DataType.DateTime)]
        [Column(TypeName="datetime2")]
        public DateTime AnswerStartHours { get; set; }

        [Display(Name = "Available Till")]
        [DataType(DataType.DateTime)]
        [Column(TypeName = "datetime2")]
        public DateTime AnswerEndHours { get; set; }

        public int AreaOfExpertiseId { get; set; }

        public virtual AreaOfExpertise AreaOfExpertise { get; set; }

        public virtual ICollection<QuestionAndAnswers> QuestionAndAnswers { get; set; }

        public virtual ICollection<LeaderBoard> LeaderBoard { get; set; }
    }
}