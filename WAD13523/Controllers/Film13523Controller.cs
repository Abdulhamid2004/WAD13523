using Microsoft.AspNetCore.Mvc;
using WAD13523.DAL.Models;
using WAD13523.DAL.Repositories;

namespace WAD13523.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Film13523Controller : ControllerBase
    {
        private readonly IRepository<Film13523> _repository;

        public Film13523Controller(IRepository<Film13523> repository)
        {
            _repository = repository;
        }

        // GET: api/Film13523
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Film13523>>> GetFilms()
        {
            var films = await _repository.GetAllItems();
            if (films == null)
            {
                return NotFound();
            }
            return Ok(films);
        }

        // GET: api/Film13523/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Film13523>> GetFilm13523(int id)
        {
            var film13523 = await _repository.GetItemByID(id);

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

            await _repository.UpdateItem(film13523);

            return NoContent();
        }

        // POST: api/Film13523
        [HttpPost]
        public async Task<ActionResult<Film13523>> PostFilm13523(Film13523 film13523)
        {
            await _repository.AddItem(film13523);

            return CreatedAtAction("GetFilm13523", new { id = film13523.ID }, film13523);
        }

        // DELETE: api/Film13523/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFilm13523(int id)
        {
            await _repository.DeleteItem(id);

            return NoContent();
        }
    }
}
