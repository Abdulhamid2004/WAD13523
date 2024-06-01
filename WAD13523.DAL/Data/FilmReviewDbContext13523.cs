using Microsoft.EntityFrameworkCore;
using WAD13523.DAL.Models;

namespace WAD13523.DAL.Data
{
    public class FilmReviewDbContext13523 : DbContext
    {
        public FilmReviewDbContext13523(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Film13523> Films { get; set; }
        public DbSet<Review13523> Reviews { get; set; }
    }
}
