using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Defining_Classes_4
{
    public class Claim
    {
        public Claim(DateTime claimDate, DateTime incidentDate, decimal amount)
        {
            IncidentDate = incidentDate;
            ClaimDate = claimDate;
            ClaimAmount = amount;
        }

        public DateTime IncidentDate { get; set; }
        public DateTime ClaimDate { get; set; }
        public decimal ClaimAmount { get; set; }
        public string ClaimHolder { get; set; }

    }
}
