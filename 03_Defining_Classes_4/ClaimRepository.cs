using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Defining_Classes_4
{
    public class ClaimRepository
    {
        public bool ValidateClaim(Claim claim)
        {
            var validAmount = CheckAmount(claim);
            var validTimeSpan = ValidateTimeSpan(claim);
            return false;
        }

        //TODO: Test
        public string CheckAmount(Claim claim)
        {
            string message = "processing";
            if (claim.ClaimAmount > 10000m)
                message = "call";
            return message;
        }

        //-- Passed
        public string ValidateTimeSpan(Claim claim)
        {
            string message = "valid";
            if ((claim.ClaimDate - claim.IncidentDate).TotalDays > 30)
                message = "invalid";
            return message;
        }
    }
}