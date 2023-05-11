using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Android.Voting.Data.Models
{
    public class Vote
    {
        

        public int Id { get; set; }
        public bool Agreed { get; set; }
        [ForeignKey("Employee")]
        public int EmpId { get; set; }
        public Employee? Employee { get; set; }
        [ForeignKey("Issue")]
        public int IssueId { get; set; }
        public Issue ?Issue { get; set; }
    }
    
}
