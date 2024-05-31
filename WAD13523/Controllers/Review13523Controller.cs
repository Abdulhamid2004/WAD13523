using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WAD13523.Data;
using WAD13523.Models;

namespace WAD13523.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Review13523Controller : ControllerBase
    {
        private readonly FilmReviewDbContext13523 _context;

        public Review13523Controller(FilmReviewDbContext13523 context)
        {
            _context = context;
        }

        // GET: api/Review13523
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Review13523>>> GetReviews()
        {
          if (_context.Reviews == null)
          {
              return NotFound();
          }
            return await _context.Reviews.ToListAsync();
        }

        // GET: api/Review13523/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Review13523>> GetReview13523(int id)
        {
          if (_context.Reviews == null)
          {
              return NotFound();
          }
            var review13523 = await _context.Reviews.FindAsync(id);

            if (review13523 == null)
            {
                return NotFound();
            }

            return review13523;
        }

        // PUT: api/Review13523/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutReview13523(int id, Review13523 review13523)
        {
            if (id != review13523.Id)
            {
                return BadRequest();
            }

            _context.Entry(review13523).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Review13523Exists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Review13523
        [HttpPost]
        public async Task<ActionResult<Review13523>> PostReview13523(Review13523 review13523)
        {
            _context.Reviews.Add(review13523);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetReview13523", new { id = review13523.Id }, review13523);
        }

        // DELETE: api/Review13523/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteReview13523(int id)
        {
            if (_context.Reviews == null)
            {
                return NotFound();
            }
            var review13523 = await _context.Reviews.FindAsync(id);
            if (review13523 == null)
            {
                return NotFound();
            }

            _context.Reviews.Remove(review13523);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Review13523Exists(int id)
        {
            return (_context.Reviews?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
