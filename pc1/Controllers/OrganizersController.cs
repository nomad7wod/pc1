using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using pc1.Data;

namespace pc1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrganizersController : ControllerBase
    {
        private readonly EventManagementDbContext _context;

        public OrganizersController(EventManagementDbContext context)
        {
            _context = context;
        }

        // GET: api/Organizers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Organizers>>> GetOrganizers()
        {
            return await _context.Organizers.ToListAsync();
        }

        // GET: api/Organizers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Organizers>> GetOrganizers(int id)
        {
            var organizers = await _context.Organizers.FindAsync(id);

            if (organizers == null)
            {
                return NotFound();
            }

            return organizers;
        }

        // PUT: api/Organizers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrganizers(int id, Organizers organizers)
        {
            if (id != organizers.Id)
            {
                return BadRequest();
            }

            _context.Entry(organizers).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrganizersExists(id))
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

        // POST: api/Organizers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Organizers>> PostOrganizers(Organizers organizers)
        {
            _context.Organizers.Add(organizers);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOrganizers", new { id = organizers.Id }, organizers);
        }

        // DELETE: api/Organizers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrganizers(int id)
        {
            var organizers = await _context.Organizers.FindAsync(id);
            if (organizers == null)
            {
                return NotFound();
            }

            _context.Organizers.Remove(organizers);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool OrganizersExists(int id)
        {
            return _context.Organizers.Any(e => e.Id == id);
        }
    }
}
