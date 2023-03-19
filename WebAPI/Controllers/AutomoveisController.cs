using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPI.Data;
using WebAPI.Model;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutomoveisController : ControllerBase
    {
        private readonly WebAPIContext _context;

        public AutomoveisController(WebAPIContext context)
        {
            _context = context;
        }

        // GET: api/Automoveis
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Automoveis>>> GetAutomoveis()
        {
          if (_context.Automoveis == null)
          {
              return NotFound();
          }
            return await _context.Automoveis.ToListAsync();
        }

        // GET: api/Automoveis/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Automoveis>> GetAutomoveis(int id)
        {
          if (_context.Automoveis == null)
          {
              return NotFound();
          }
            var automoveis = await _context.Automoveis.FindAsync(id);

            if (automoveis == null)
            {
                return NotFound();
            }

            return automoveis;
        }

        // PUT: api/Automoveis/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAutomoveis(int id, Automoveis automoveis)
        {
            if (id != automoveis.ID)
            {
                return BadRequest();
            }

            _context.Entry(automoveis).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AutomoveisExists(id))
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

        // POST: api/Automoveis
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Automoveis>> PostAutomoveis(Automoveis automoveis)
        {
          if (_context.Automoveis == null)
          {
              return Problem("Entity set 'WebAPIContext.Automoveis'  is null.");
          }
            _context.Automoveis.Add(automoveis);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAutomoveis", new { id = automoveis.ID }, automoveis);
        }

        // DELETE: api/Automoveis/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAutomoveis(int id)
        {
            if (_context.Automoveis == null)
            {
                return NotFound();
            }
            var automoveis = await _context.Automoveis.FindAsync(id);
            if (automoveis == null)
            {
                return NotFound();
            }

            _context.Automoveis.Remove(automoveis);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AutomoveisExists(int id)
        {
            return (_context.Automoveis?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
