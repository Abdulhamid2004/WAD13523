using Microsoft.EntityFrameworkCore;
using WAD13523.DAL.Data;
using WAD13523.DAL.Models;

namespace WAD13523.DAL.Repositories
{
    public class FilmRepository13523 : IRepository<Film13523>
    {
        private readonly FilmReviewDbContext13523 _context;

        public FilmRepository13523(FilmReviewDbContext13523 context)
        {
            _context = context;
        }

        public async Task AddItem(Film13523 entity)
        {
            _context.Films.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteItem(int id)
        {
            var entity = await _context.Films.FindAsync(id);
            if (entity != null)
            {
                _context.Films.Remove(entity);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Film13523>> GetAllItems()
        {
            return await _context.Films.ToListAsync();
        }

        public async Task<Film13523> GetItemByID(int id)
        {
            return await _context.Films.FindAsync(id);
        }

        public async Task UpdateItem(Film13523 entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
