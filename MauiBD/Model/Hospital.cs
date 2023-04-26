

namespace MauiBD.Model;
    public class Hospital
    {
        public int id { get; set; }
        public string title { get; set; }
        public string slug { get; set; }
        public string logo { get; set; }
        public string longitude { get; set; }
        public string latitude { get; set; }
        public string region { get; set; }
        public string country { get; set; }
        public string town { get; set; }
        public string email { get; set; }
        public List<Service> services { get; set; }
        public string birth { get; set; }
    }
