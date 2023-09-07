using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Proyectoinv.Shared.Entities;

namespace Proyectoinv.API.Data
{
    public class ProyectoinvAPIContext : DbContext
    {
        public ProyectoinvAPIContext (DbContextOptions<ProyectoinvAPIContext> options)
            : base(options)
        {
        }

        public DbSet<Proyectoinv.Shared.Entities.Proyectoinvestigacion> Proyectoinvestigacion { get; set; } = default!;

        public DbSet<Proyectoinv.Shared.Entities.Investigador> Investigador { get; set; } = default!;
    }
}
