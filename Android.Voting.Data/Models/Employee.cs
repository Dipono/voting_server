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

        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public string EmailAddress { get; set; }

        public string Password { get; set; }

        public string Role { get; set; }
    }
}
