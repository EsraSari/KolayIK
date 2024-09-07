using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolayIK.Core.Modal
{
    public class Event: BaseClass
    {
        public int? CompanyID { get; set; }
        public Company Company { get; set; }
        public string EventName { get; set; }
        public EventType EventType { get; set; }
        public int EventTypeID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
