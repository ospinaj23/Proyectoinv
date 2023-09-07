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
    public class ProyectoinvestigacionsController : ControllerBase
    {
        private readonly ProyectoinvAPIContext _context;

        public ProyectoinvestigacionsController(ProyectoinvAPIContext context)
        {
            _context = context;
        }

        // GET: api/Proyectoinvestigacions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Proyectoinvestigacion>>> GetProyectoinvestigacion()
        {
          if (_context.Proyectoinvestigacion == null)
          {
              return NotFound();
          }
            return await _context.Proyectoinvestigacion.ToListAsync();
        }

        // GET: api/Proyectoinvestigacions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Proyectoinvestigacion>> GetProyectoinvestigacion(int id)
        {
          if (_context.Proyectoinvestigacion == null)
          {
              return NotFound();
          }
            var proyectoinvestigacion = await _context.Proyectoinvestigacion.FindAsync(id);

            if (proyectoinvestigacion == null)
            {
                return NotFound();
            }

            return proyectoinvestigacion;
        }

        // PUT: api/Proyectoinvestigacions/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProyectoinvestigacion(int id, Proyectoinvestigacion proyectoinvestigacion)
        {
            if (id != proyectoinvestigacion.Id)
            {
                return BadRequest();
            }

            _context.Entry(proyectoinvestigacion).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProyectoinvestigacionExists(id))
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

        // POST: api/Proyectoinvestigacions
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Proyectoinvestigacion>> PostProyectoinvestigacion(Proyectoinvestigacion proyectoinvestigacion)
        {
          if (_context.Proyectoinvestigacion == null)
          {
              return Problem("Entity set 'ProyectoinvAPIContext.Proyectoinvestigacion'  is null.");
          }
            _context.Proyectoinvestigacion.Add(proyectoinvestigacion);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProyectoinvestigacion", new { id = proyectoinvestigacion.Id }, proyectoinvestigacion);
        }

        // DELETE: api/Proyectoinvestigacions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProyectoinvestigacion(int id)
        {
            if (_context.Proyectoinvestigacion == null)
            {
                return NotFound();
            }
            var proyectoinvestigacion = await _context.Proyectoinvestigacion.FindAsync(id);
            if (proyectoinvestigacion == null)
            {
                return NotFound();
            }

            _context.Proyectoinvestigacion.Remove(proyectoinvestigacion);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ProyectoinvestigacionExists(int id)
        {
            return (_context.Proyectoinvestigacion?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
