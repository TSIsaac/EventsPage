using Microsoft.VisualBasic;

namespace EventsPage.Models
{
    public class Event
    {

        public int  id { get; set; }
        public string name { get; set; }

        public string description { get; set; }

        public string type { get; set; }

        public string location { get; set; }

        public string date { get; set; }
        
        public Event()
        {

        }
    }
}
