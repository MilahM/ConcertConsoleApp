using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcertConsoleApp
{
    public interface IEventByArtist
    {
        public IEnumerable<Events> GetEventByArtist(string name);
    }
}
