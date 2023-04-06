using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Sigorta
{
    public class PolicyList
    {
        public string CustomerName { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime EndDate { get; set; }
        public string PolicyTypeName { get; set; }
        public string PlateNumber { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal PaidAmount { get; set; }
        public decimal RemainingAmount { get; set; }

    }
}
