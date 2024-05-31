
using System.Text.Json.Serialization;

namespace WAD13523.Models
{
    public class Film13523
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Director { get; set; }
        public string Genre { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int Duration { get; set; }
        public string Summary { get; set; }
        [JsonIgnore]
        public ICollection<Review13523> Reviews { get; set; }
    }
}
