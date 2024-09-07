using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolayIK.Core.Modal
{
    public class EventType: BaseClass
    {
        public string EventTypeName { get; set; }
        public List<Event> Events { get; set; }
    }
}
