using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Android.Voting.Data.Models
{
    public class Employee
    {
        public Employee()
        {
            Firstname = string.Empty;
            Lastname = string.Empty;
            EmailAddress = string.Empty;
            Password = string.Empty;
            Role = string.Empty;
        }
        public int Id { get; set; }

        [Display(Name = "Firstname")]
        [MinLength(3), MaxLength(30)]
        public string Firstname { get; set; }

        [Display(Name = "Lastname")]
        [MinLength(3), MaxLength(30)]
        public string Lastname { get; set; }


        [Display(Name = "Email Address")]
        [MinLength(8), MaxLength(255)]
        [Required(ErrorMessage = "Email Address is Required")]
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }

        [Display(Name = "Password")]
        [MinLength(8), MaxLength(30)]
        public string Password { get; set; }

        public string Role { get; set; }
    }
}
