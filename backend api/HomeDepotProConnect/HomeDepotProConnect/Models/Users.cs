using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HomeDepotProConnect.Models
{
    public class Users
    {
        [Key]
        public int UsersId { get; set; }

        [Display(Name ="First Name")]
        [MaxLength(30, ErrorMessage ="The first name must be maximum 30 characters long")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [MaxLength(30, ErrorMessage = "The last name must be maximum 30 characters long")]
        public string LastName { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Device")]
        public int DeviceId { get; set; }

        [Display(Name = "Additional device")]
        public int AdditionalDeviceId { get; set; }

        public virtual ICollection<QuestionAndAnswers> QuestionAndAnswers { get; set; }

    }
}