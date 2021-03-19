using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SmartLearningOpgave1.Models
{
    public class User
    {
        [Required]
        public string firstName { get; set; }
        [Required]
        public string lastName { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Please enter a valid email")]
        public string email { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Please enter a valid email")]
        [Compare("email", ErrorMessage = "Email address does not match")]
        public string confirmEmail { get; set; }

        [Required]
        public string city { get; set; }

        [Required]
        public string country { get; set; }

    }
}
