using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EthioAct.Areas.Actor.Models
{
    public class ActorBasicProfileViewModel
    {
        [Required]
        [Display(Name = "First Name")]
        public string firstName { get; set; }
        [Required]
        [Display(Name = "Father Name")]
        public string secondName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string lastName { get; set; }
        [Required]
        [Display(Name = "Date of Birth")]
        public Nullable<System.DateTime> dateOfBirth { get; set; }

        [Required]
        [Display(Name = "Gender")]
        public string gender { get; set; }

        
        [Display(Name = "Hieght")]
        public double height { get; set; }
        [Display(Name = "Hieght")]
        public Nullable<double> weight { get; set; }
        [Display(Name = "Education Level")]
        public string educationLevel { get; set; }
        [Display(Name = "Address")]
        public Nullable<int> addressId { get; set; }
        [Display(Name = "Email")]
        [EmailAddress]
        public string emailAddress { get; set; }
    }
}