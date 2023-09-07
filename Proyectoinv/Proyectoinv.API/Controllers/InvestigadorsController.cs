using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Proyectoinv.API.Data;
using Proyectoinv.Shared.Entities;

namespace Proyectoinv.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvestigadorsController : ControllerBase
    {
        private readonly ProyectoinvAPIContext _context;

        public InvestigadorsController(ProyectoinvAPIContext context)
        {
            _context = context;
        }

        // GET: api/Investigadors
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Investigador>>> GetInvestigador()
        {
          if (_context.Investigador == null)
          {
              return NotFound();
          }
            return await _context.Investigador.ToListAsync();
        }

        // GET: api/Investigadors/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Investigador>> GetInvestigador(int id)
        {
          if (_context.Investigador == null)
          {
              return NotFound();
          }
            var investigador = await _context.Investigador.FindAsync(id);

            if (investigador == null)
            {
                return NotFound();
            }

            return investigador;
        }

        // PUT: api/Investigadors/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutInvestigador(int id, Investigador investigador)
        {
            if (id != investigador.Id)
            {
                return BadRequest();
            }

            _context.Entry(investigador).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InvestigadorExists(id))
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

        // POST: api/Investigadors
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Investigador>> PostInvestigador(Investigador investigador)
        {
          if (_context.Investigador == null)
          {
              return Problem("Entity set 'ProyectoinvAPIContext.Investigador'  is null.");
          }
            _context.Investigador.Add(investigador);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetInvestigador", new { id = investigador.Id }, investigador);
        }

        // DELETE: api/Investigadors/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteInvestigador(int id)
        {
            if (_context.Investigador == null)
            {
                return NotFound();
            }
            var investigador = await _context.Investigador.FindAsync(id);
            if (investigador == null)
            {
                return NotFound();
            }

            _context.Investigador.Remove(investigador);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool InvestigadorExists(int id)
        {
            return (_context.Investigador?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
