using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcertConsoleApp
{
    public class EventByArtistRepository : IEventByArtist
    {
        public IEnumerable<Events> GetEventByArtist(string apiCall)
        {
            var client = new HttpClient();

            var artistUrlResponse = client.GetStringAsync(apiCall).Result;

            var artistEvents = JObject.Parse(artistUrlResponse)["events"]["datetime_utc"]["venue"]["name"]["url"].ToList();

            return (IEnumerable<Events>)artistEvents;
        }
    }
}
