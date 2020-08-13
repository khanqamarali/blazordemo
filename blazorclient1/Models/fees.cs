using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blazorclient1.Models
{
    public class Fees : IFees
    {
        public int feeAmount { get; set; }
        public List<string> GetFees()
        {
            return new List<string>() { "$12", "$15" };
        }
    }
}
