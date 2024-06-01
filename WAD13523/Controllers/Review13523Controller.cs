using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WAD13523.DAL.Models;
using WAD13523.DAL.Repositories;

namespace WAD13523.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Review13523Controller : ControllerBase
    {
        private readonly IRepository<Review13523> _repository;

        public Review13523Controller(IRepository<Review13523> repository)
        {
            _repository = repository;
        }

        // GET: api/Review13523
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Review13523>>> GetReviews()
        {
            var reviews = await _repository.GetAllItems();
            if (reviews == null)
            {
                return NotFound();
            }
            return Ok(reviews);
        }

        // GET: api/Review13523/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Review13523>> GetReview13523(int id)
        {
            var review13523 = await _repository.GetItemByID(id);

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

            await _repository.UpdateItem(review13523);

            return NoContent();
        }

        // POST: api/Review13523
        [HttpPost]
        public async Task<ActionResult<Review13523>> PostReview13523(Review13523 review13523)
        {
            await _repository.AddItem(review13523);

            return CreatedAtAction("GetFilm13523", new { id = review13523.Id }, review13523);
        }

        // DELETE: api/Review13523/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteReview13523(int id)
        {
            await _repository.DeleteItem(id);

            return NoContent();
        }
    }
}
