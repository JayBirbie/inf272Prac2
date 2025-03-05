using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JayStudyGroupProfiles.Models
{
    public class PersonModel
    { 
 
        [Display(Name = "Student Number")]
        public string stuNum { get; set; }

        [Display(Name = "First Name")]
        public string fName { get; set; }

        [Display(Name = "Last Name")]
        public string lName { get; set; }

        [Display(Name = "Email Address")]
        public string email { get; set; }

        [Display(Name = "Link to Personal Page")]
        public string myLink { get; set; }
    }
}