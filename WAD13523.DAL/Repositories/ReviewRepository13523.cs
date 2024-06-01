using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WAD13523.DAL.Data;
using WAD13523.DAL.Models;

namespace WAD13523.DAL.Repositories
{
    public class ReviewRepository13523 : IRepository<Review13523>
    {
        private readonly FilmReviewDbContext13523 _context;

        public ReviewRepository13523(FilmReviewDbContext13523 context)
        {
            _context = context;
        }

        public async Task AddItem(Review13523 entity)
        {
            _context.Reviews.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteItem(int id)
        {
            var entity = await _context.Reviews.FindAsync(id);
            if (entity != null)
            {
                _context.Reviews.Remove(entity);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Review13523>> GetAllItems()
        {
            return await _context.Reviews.ToListAsync();
        }

        public async Task<Review13523> GetItemByID(int id)
        {
            return await _context.Reviews.FindAsync(id);
        }

        public async Task UpdateItem(Review13523 entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
