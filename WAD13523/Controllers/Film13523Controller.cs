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
    public class Film13523Controller : ControllerBase
    {
        private readonly FilmReviewDbContext13523 _context;

        public Film13523Controller(FilmReviewDbContext13523 context)
        {
            _context = context;
        }

        // GET: api/Film13523
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Film13523>>> GetFilms()
        {
          if (_context.Films == null)
          {
              return NotFound();
          }
            return await _context.Films.ToListAsync();
        }

        // GET: api/Film13523/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Film13523>> GetFilm13523(int id)
        {
          if (_context.Films == null)
          {
              return NotFound();
          }
            var film13523 = await _context.Films.FindAsync(id);

            if (film13523 == null)
            {
                return NotFound();
            }

            return film13523;
        }

        // PUT: api/Film13523/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFilm13523(int id, Film13523 film13523)
        {
            if (id != film13523.ID)
            {
                return BadRequest();
            }

            _context.Entry(film13523).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Film13523Exists(id))
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

        // POST: api/Film13523
        [HttpPost]
        public async Task<ActionResult<Film13523>> PostFilm13523(Film13523 film13523)
        {
            _context.Films.Add(film13523);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFilm13523", new { id = film13523.ID }, film13523);
        }

        // DELETE: api/Film13523/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFilm13523(int id)
        {
            if (_context.Films == null)
            {
                return NotFound();
            }
            var film13523 = await _context.Films.FindAsync(id);
            if (film13523 == null)
            {
                return NotFound();
            }

            _context.Films.Remove(film13523);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Film13523Exists(int id)
        {
            return (_context.Films?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
