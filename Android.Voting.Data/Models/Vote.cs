using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Android.Voting.Data.Models
{
    public class Vote
    {
        
            public Vote()
            {
                Isuue = string.Empty;
            }
            public int Id { get; set; }
            public string Isuue { get; set; }
            public DateTime SatrtDate { get; set; }
            public DateTime EndDate { get; set; }
            public int Agreed { get; set; }
            public int Disagreed { get; set; }

        }
    
}
