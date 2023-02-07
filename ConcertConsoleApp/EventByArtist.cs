using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcertConsoleApp
{
    public class EventByArtist
    {
        private readonly HttpClient _client;
        public EventByArtist(HttpClient client)
        {
            _client = client;
        }
        
    }
}
