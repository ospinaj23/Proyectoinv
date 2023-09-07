using Proyectoinv.API.Data;
using Proyectoinv.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Proyectoinv.API.Controllers
{
    [ApiController]
    [Route("api/proyectoinv")]
    public class ProyectoinvController : ControllerBase
    {

        private readonly DataContext _context;

        public ProyectoinvController(DataContext context)
        {



            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.Proyectoinv.ToListAsync());
        }



        [HttpPost]
        public async Task<ActionResult> Post(Proyectoinvestigacion Proyectoinv)
        {

            _context.Add(Proyectoinv);
            await _context.SaveChangesAsync();
            return Ok(Proyectoinv);
        }

    }
}