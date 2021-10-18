using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Movies.Data;
using Movies.Models;

namespace Movies.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly ApiDbContext _context;

        public MoviesController(ApiDbContext context)
        {
            _context = context;
        }

        // [Route("Movies")]
        [HttpGet]
        public async Task<IActionResult> GetMovies()
        {
            var tb_movies = await _context.tb_movie.ToListAsync();

            return Ok(tb_movies);
        }

        [HttpPost]
        public async Task<IActionResult> CreateMovie(MovieData data)
        {
            if (ModelState.IsValid)
            {
                await _context.tb_movie.AddAsync(data);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetMovie", new { data.Id }, data);
            }

            return new JsonResult("Something went wrong") { StatusCode = 500 };
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetMovie(int id)
        {
            var item = await _context.tb_movie.FirstOrDefaultAsync(x => x.Id == id);

            if (item == null)
            {
                return NotFound();
            }
            return Ok(item);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateMovie(int id, MovieData item)
        {
            if (id != item.Id)
            {
                return BadRequest();
            }

            var existItem = await _context.tb_movie.FirstOrDefaultAsync(x => x.Id == id);

            if (existItem == null)
            {
                return NotFound();
            }

            existItem.Name = item.Name;
            existItem.Genre = item.Genre;
            existItem.Duration = item.Duration;
            existItem.ReleaseDate = item.ReleaseDate;

            //Implement the changes on the database level
            await _context.SaveChangesAsync();

            return Ok(item);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMovie(int id)
        {
            var existItem = await _context.tb_movie.FirstOrDefaultAsync(x => x.Id == id);

            if (existItem == null)
            {
                return NotFound();
            }

            _context.tb_movie.Remove(existItem);
            await _context.SaveChangesAsync();

            return Ok(existItem);
        }
    }
}