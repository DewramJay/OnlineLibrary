using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using prrr.models;

namespace prrr.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookStatusController : ControllerBase
    {
        private readonly LibraryContext _context;

        public BookStatusController(LibraryContext context)
        {
            _context = context;
        }

        // GET: api/BookStatus
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BookStatus>>> GetbookStatuses()
        {
            return await _context.bookStatuses.ToListAsync();
        }

        // GET: api/BookStatus/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BookStatus>> GetBookStatus(int id)
        {
            var bookStatus = await _context.bookStatuses.FindAsync(id);

            if (bookStatus == null)
            {
                return NotFound();
            }

            return bookStatus;
        }

        // PUT: api/BookStatus/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBookStatus(int id, BookStatus bookStatus)
        {
            if (id != bookStatus.Id)
            {
                return BadRequest();
            }

            _context.Entry(bookStatus).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BookStatusExists(id))
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

        // POST: api/BookStatus
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<BookStatus>> PostBookStatus(BookStatus bookStatus)
        {
            _context.bookStatuses.Add(bookStatus);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetBookStatus), new { id = bookStatus.Id }, bookStatus);
        }

        // DELETE: api/BookStatus/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBookStatus(int id)
        {
            var bookStatus = await _context.bookStatuses.FindAsync(id);
            if (bookStatus == null)
            {
                return NotFound();
            }

            _context.bookStatuses.Remove(bookStatus);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BookStatusExists(int id)
        {
            return _context.bookStatuses.Any(e => e.Id == id);
        }
    }
}
