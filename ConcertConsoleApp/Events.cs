using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcertConsoleApp
{
    public class Events
    {
        public string type { get; set; }
        public DateTime datetime_local { get; set; }
        public Venue venue { get; set; }
        public string url { get; set; }

    }
}
