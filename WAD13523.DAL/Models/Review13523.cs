namespace WAD13523.DAL.Models
{
    public class Review13523
    {
        public int Id { get; set; }
        public double Rating { get; set; }
        public string Comment { get; set; }
        public bool HasSpoilers { get; set; }
        public int FilmId { get; set; }
        public Film13523? Film { get; set; }
    }
}
