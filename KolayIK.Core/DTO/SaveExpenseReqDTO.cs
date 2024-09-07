using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolayIK.Core.DTO
{
    public class SaveExpenseReqDTO
    {
        public int UserID { get; set; }
        public double Amount { get; set; }
        public string Description { get; set; }
        public int StateID { get; set; }
        public DateTime? ApprovalDate { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
