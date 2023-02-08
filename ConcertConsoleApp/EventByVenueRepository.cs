using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcertConsoleApp
{
    public class EventByVenueRepository
    {
        private readonly HttpClient _client;
        public EventByVenueRepository(HttpClient client)
        {
            _client = client;
        }
        public static List<Venue> GetEventByVenue(string apiCall)
        {
            var client = new HttpClient();

            var venueUrlResponse = client.GetStringAsync(apiCall).Result;

            var venueEvents = JObject.Parse(venueUrlResponse)["events"].ToString();

            List<Venue> events = JsonConvert.DeserializeObject<List<Venue>>(venueEvents);

            foreach (var item in events)
            {
                Console.WriteLine(item.name);
                Console.WriteLine(item.name_v2);
                Console.WriteLine(item.city);
                Console.WriteLine(item.state);
                Console.WriteLine(item.url);
            }

            return events;
        }
    }
}
