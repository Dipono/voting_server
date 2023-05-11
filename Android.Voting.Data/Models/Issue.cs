using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Android.Voting.Data.Models
{
    public class Issue
    {
        public Issue()
        {
            IssueDesc = string.Empty;
            StartTime = string.Empty;
            EndTime = string.Empty;
            //Votes = new List<Vote>();
        }
        public int Id { get; set; }
        public string IssueDesc { get; set; }
        //[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString ="{0:yyyy-MM-dd HH:mm}")]
        public String StartTime { get; set; }

        //[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd HH:mm}")]
        public string EndTime { get; set; }
       // public List<Vote> Votes { get; set; }
    }
}
