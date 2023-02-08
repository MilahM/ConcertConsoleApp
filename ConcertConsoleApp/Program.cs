using Newtonsoft.Json.Linq;

namespace ConcertConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            string auth = File.ReadAllText("appsettings.json");

            string authKey = JObject.Parse(auth).GetValue("client_id").ToString();

            Console.WriteLine("Search events by artist name.");

            var artistName = Console.ReadLine();

            string apiCall = $"https://api.seatgeek.com/2/events?performers.slug={artistName}&client_id={authKey}";

            Console.WriteLine($"Here are Concerts for {artistName}:");

            Console.WriteLine(EventByArtistRepository.GetEventByArtist(apiCall));

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Search events by venue city.");

            var venueCity = Console.ReadLine();

            string apiCall2 = $"https://api.seatgeek.com/2/events?venue.city={venueCity}&client_id={authKey}";

            Console.WriteLine($"Here are Events in {venueCity}:");

            Console.WriteLine(EventByVenueRepository.GetEventByVenue(apiCall2));
        }
    }
}