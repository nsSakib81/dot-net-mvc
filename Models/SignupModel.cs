using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace validation.Models
{
    public class SignupModel
    {

        [RegularExpression(@"^[A-Za-z\s\.,\-]+$", ErrorMessage = "Invalid! enter again!!no number and special character allowed")]

        [Required]
        public string Name { get; set; }
        [RegularExpression(@"^[A-Za-z0-9_]{5,7}$", ErrorMessage = "Invalid! length should be 5-7 and dot,desh not allowed")]

        [Required]
        public string Username { get; set; }
        [RegularExpression(@"^[0-9]{2}-\d{5}-[0-9]@Student\.aiub\.edu$", ErrorMessage = "Invalid email!! enter XX-XXXXX-X@Student.aiub.edu format")]

        [Required]
        public string Email { get; set; }
        [RegularExpression(@"^[0-9]{2}-\d{5}-\d$", ErrorMessage = "enter xx-xxxxx-x format!!")]
        [Required]
        public string StudentID { get; set; }
        [RegularExpression(@"^(?=.*[A-Za-z].*[A-Za-z])(?=.*\d)(?=.*[@#$%^&+=!]).{8,}$", ErrorMessage = "Invalid!! enter 8 character,2 alphabet,1 number, 2 special character")]

        [Required]
        public string Password { get; set; }
        
        [Required]
        public DateTime DateOfBirth { get; set; }

    }
}
