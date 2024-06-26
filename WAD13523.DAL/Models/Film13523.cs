﻿
using System.Text.Json.Serialization;

namespace WAD13523.DAL.Models
{
    public class Film13523
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Director { get; set; }
        public string Genre { get; set; }
        public int ReleaseYear { get; set; }
        public int Duration { get; set; }
        public string Summary { get; set; }
        public ICollection<Review13523>? Reviews { get; set; } = new List<Review13523>();
    }
}
